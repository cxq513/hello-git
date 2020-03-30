using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmClassDelect : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();

        public FrmClassDelect()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }

        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            combSpecialityName.DataSource = null;
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.SelectedIndex = -1;
            this.combSpecialityName.SelectedIndexChanged += new System.EventHandler(this.combSpecialityName_SelectedIndexChanged);
        }

        //根据专业ID查询班级
        private void combSpecialityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combSpecialityName.DataSource != null)
            {
                combClassName.DataSource = null;
                this.combClassName.DataSource = objStudentService.GetClassNameBySpecialityID(combSpecialityName.SelectedValue.ToString()).Tables[0].DefaultView;
                this.combClassName.DisplayMember = "ClassName";
                this.combClassName.ValueMember = "ClassID";
                this.combClassName.SelectedIndex = -1;
            }
            else
            {
                combClassName.DataSource = null;
            }
            //if (combSpecialityName.Text == "")
            //{
            //    this.combClassName.Text = null;
            //}
            //else
            //{
            //    this.combClassName.DataSource = null;
            //    this.combClassName.DataSource = objClassService.GetClassNameBySpecialityID(combSpecialityName.SelectedValue.ToString()).Tables[0].DefaultView;
            //    this.combClassName.DisplayMember = "ClassName";
            //    this.combClassName.ValueMember = "ClassID";
            //    combClassName.SelectedIndex = -1;
            //}
        }

        //查询班级信息
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.combClassName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择要查询的班级！", "查询提示");
                this.combClassName.Focus();
                return;
            }
            //根据班级名字查询班级对象
            Class objClass = objClassService.GetClass(this.combClassName.Text.Trim());
            if (objClass == null)
            {
                MessageBox.Show("您输入的班级不正确，未找到该班级信息", "查询提示");
                this.combClassName.Focus();
                this.combClassName.SelectAll();
                return;
            }
            else
            {
                this.txtClassNum.Text = objClass.ClassNum.ToString();
                this.numericUpDownSchoolReform.Value = Convert.ToInt32(objClass.SchoolReform.ToString());
                this.txtHeadTeacher.Text = objClass.HeadTeacher.ToString();
                this.dateTimeEnrolmentTime.Text = objClass.EnrolmentTime.ToString();
                this.txtRemark.Text = objClass.Remark.ToString();
            }
        }
        //删除班级信息
        private void btnDelect_Click(object sender, EventArgs e)
        {
            if (this.combCollageName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学院！", "删除提示");
                this.combCollageName.Focus();
                return;
            }

            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择专业！", "删除提示");
                this.combSpecialityName.Focus();
                return;
            }

            if (combClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请填选择班级名称！", "删除提示");
                this.combClassName.Focus();
                return;
            }
            if (txtHeadTeacher.Text == "") 
            {
                MessageBox.Show("请点击查询确认要删除的班级信息！", "删除提示");
                this.combClassName.Focus();
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的专业名称
            string CollageName = this.combClassName.Text.Trim();
            //根据学号删除
            try
            {
                if (objClassService.DeleteClass(CollageName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    //初始化专业下拉框
                    this.combSpecialityName.DataSource = objSpecialityService.GetSpeciality().Tables[0].DefaultView;
                    this.combSpecialityName.DisplayMember = "SpecialityName";
                    this.combSpecialityName.ValueMember = "SpecialityID";
                    this.combSpecialityName.Text = "";
                    this.combSpecialityName.SelectedIndexChanged += new System.EventHandler(this.combSpecialityName_SelectedIndexChanged);
                    this.txtClassNum.Text = null;
                    this.numericUpDownSchoolReform.Value = 0;
                    this.txtHeadTeacher.Text = null;
                    this.dateTimeEnrolmentTime.Text = DateTime.Today.ToString();
                    this.txtRemark.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "删除信息");
            }
        }
        //取消关闭当前窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
