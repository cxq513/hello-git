using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using WeifenLuo.WinFormsUI.Docking;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmClassSearch : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        public FrmClassSearch()
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
        }

        //查询班级信息
        private void btnSerach_Click(object sender, EventArgs e)
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
        
        //优化用户体验，回车查询
        private void combClassName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.combClassName.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnSerach_Click(null, null);
                this.combClassName.Focus();
            }
        }
        //取消关闭当前窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combCollageName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

