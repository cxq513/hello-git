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
using Commons;
using DAL;
using Models;

namespace Students_Information_Sys
{

    public partial class FrmStudentDelect : DockContent
    {
        private StudentService objStudentService = new StudentService();
        public FrmStudentDelect()
        {
            InitializeComponent();
        }

        private void btnstu_search_Click(object sender, EventArgs e)
        {
            if (this.txtStudentNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入要查询的学号！", "信息提示");
                this.txtStudentNumber.Focus();
                return;
            }
            //根据学号查询学学生对象
            Student objStudent = objStudentService.GetStudent(this.txtStudentNumber.Text.Trim());
            if (objStudent == null)
            {
                MessageBox.Show("您输入的学号不正确，未找到该学生信息", "信息提示");
                this.txtStudentNumber.Focus();
                this.txtStudentNumber.SelectAll();
                return;
            }
            else
            {
                this.txtStudentNumber.Text = objStudent.StudentNumber.ToString();
                this.txtStudentName.Text = objStudent.StudentName;
                txtStudentSex.Text = objStudent.StudentSex;
                dateTimeStudentBrithday.Text = objStudent.StudentBrithday.ToString();
                txtIDnumber.Text = objStudent.IDnumber;
                txtStudentAddress.Text = objStudent.StudentPhoneNumber;
                txtStudentNation.Text = objStudent.StudentNation;
                txtStudentNativeplace.Text = objStudent.StudentNativeplace;
                txtStudentAddress.Text = objStudent.StudentAddress;
                txtStudentPolitical.Text = objStudent.StudentPolitical;
                txtCollageName.Text = objStudent.StudentCollage;
                txtStudentJob.Text = objStudent.StudentJob;
                txtStudentPhoneNumber.Text = objStudent.StudentPhoneNumber;
                txtSpecialityName.Text = objStudent.SpecialityName;
                txtClassName.Text = objStudent.ClassName;
                pictureBoxStudentPhoto.Image = objStudent.StudentPhoneNumber.Length == 0 ? Image.FromFile("NoPicture.jpg") :
                    (Image)new SerializeObjectToString().DeserializeObject(objStudent.StudentPhoto);
            }
        }

        private void btnsDelete_Click(object sender, EventArgs e)
        {
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string StudentNumber = this.txtStudentNumber.Text.Trim();
            //根据学号删除
            try
            {
                if (objStudentService.DeleteStudent(StudentNumber) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    this.txtStudentNumber.Text = null;
                    this.txtStudentName.Text = null;
                    txtStudentSex.Text = null;
                    dateTimeStudentBrithday.Text = DateTime.Today.ToString();
                    txtIDnumber.Text = null;
                    txtStudentAddress.Text = null;
                    txtStudentNation.Text = null;
                    txtStudentNativeplace.Text = null;
                    txtStudentAddress.Text = null;
                    txtStudentPolitical.Text = null;
                    txtCollageName.Text = null;
                    txtStudentJob.Text = null;
                    txtStudentPhoneNumber.Text = null;
                    txtSpecialityName.Text = null;
                    txtClassName.Text = null;
                    pictureBoxStudentPhoto.Image = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "删除信息");
            }
        }
        //取消关闭当前窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

