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
    public partial class FrmClassUpdate : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        public FrmClassUpdate()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }
        //根据专业ID查询班级
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
        }

        //查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.combClassName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择要查询的班级！", "信息提示");
                this.combClassName.Focus();
                return;
            }
            //根据班级名字查询班级对象
            Class objClass = objClassService.GetClass(this.combClassName.Text.Trim());
            if (objClass == null)
            {
                MessageBox.Show("您输入的班级不正确，未找到该班级信息", "信息提示");
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

        //修改班级
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            if (this.combCollageName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学院！", "信息提示");
                this.combCollageName.Focus();
                return;
            }

            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择专业！", "信息提示");
                this.combSpecialityName.Focus();
                return;
            }

            if (combClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请填选择班级名称！", "信息提示");
                this.combClassName.Focus();
                return;
            }

            if (txtClassNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写教室编号！", "信息提示");
                this.txtClassNum.Focus();
                return;
            }
            if (txtHeadTeacher.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写班主任！", "信息提示");
                this.txtHeadTeacher.Focus();
                return;
            }

            //封装班级信息
            Class objClass = new Class()
            {
                SchoolReform = numericUpDownSchoolReform.Value,
                EnrolmentTime = dateTimeEnrolmentTime.Value,
                HeadTeacher = txtHeadTeacher.Text.Trim(),
                ClassNum = txtClassNum.Text.Trim(),
                ClassName = combClassName.Text.Trim(),
                Remark = txtRemark.Text.Trim()
            };
            //提交对象
            //判断是否保存成功
            try
            {
                int result = objClassService.UpdateClass(objClass);
                if (result == 1)
                {
                    MessageBox.Show("专业班级修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    this.combClassName.Focus();

                }
                else
                {
                    MessageBox.Show("专业班级修改失败", "添加提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //取消关闭当前窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
