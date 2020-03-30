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
    public partial class FrmClassUpdateByBrowse : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private CollageService objCollageService = new CollageService();
        private StudentService objStudentService = new StudentService();
        public FrmClassUpdateByBrowse()
        {
            InitializeComponent();
        }

        //通过浏览班级信息加载
        public FrmClassUpdateByBrowse(Class objClass)
        {
            InitializeComponent();
            combClassName.Text = objClass.ClassName.ToString();
            combSpecialityName.Text = objClass.SpecialityName.ToString();
            this.txtClassNum.Text = objClass.ClassNum.ToString();
            this.numericUpDownSchoolReform.Value = Convert.ToInt32(objClass.SchoolReform.ToString());
            this.txtHeadTeacher.Text = objClass.HeadTeacher.ToString();
            this.dateTimeEnrolmentTime.Text = objClass.EnrolmentTime.ToString();
            this.txtRemark.Text = objClass.Remark.ToString();
        }
        //查询按钮
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
        //修改按钮
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
                if (txtClassNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写教室编号！", "修改提示");
                this.txtClassNum.Focus();
                return;
            }
            if (txtHeadTeacher.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写班主任！", "修改提示");
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
                    MessageBox.Show("班级名称不可修改！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
