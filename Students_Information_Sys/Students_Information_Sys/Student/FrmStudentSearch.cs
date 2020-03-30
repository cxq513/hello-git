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
using System.IO;
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmStudentSearch : DockContent
    {
        private StudentService objStudentService = new StudentService();
        public FrmStudentSearch()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示浏览学生信息中按学号查找的学生信息
        /// </summary>
        /// <param name="objStudent"></param>
        public FrmStudentSearch(Student objStudent)
        {
            InitializeComponent();
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
            txtStudentCollage.Text = objStudent.StudentCollage;
            txtStudentJob.Text = objStudent.StudentJob;
            txtstu_phone.Text = objStudent.StudentPhoneNumber;
            txtStudentCollage.Text = objStudent.StudentCollage;
            txtSpecialityName.Text = objStudent.SpecialityName;
            txtClassName.Text = objStudent.ClassName;
            pictureBoxStudentPhoto.Image = objStudent.StudentPhoneNumber.Length == 0 ? Image.FromFile("NoPicture.jpg") :
                (Image)new SerializeObjectToString().DeserializeObject(objStudent.StudentPhoto);
        }

        //查找学生信息
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
                txtStudentCollage.Text = objStudent.StudentCollage;
                txtStudentJob.Text = objStudent.StudentJob;
                txtstu_phone.Text = objStudent.StudentPhoneNumber;
                txtSpecialityName.Text = objStudent.SpecialityName;
                txtClassName.Text = objStudent.ClassName;
                pictureBoxStudentPhoto.Image = objStudent.StudentPhoneNumber.Length == 0 ? Image.FromFile("NoPicture.jpg") :
                    (Image)new SerializeObjectToString().DeserializeObject(objStudent.StudentPhoto);
            }
        }

        private void txtStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStudentNumber.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnstu_search_Click(null, null);
                this.txtStudentNumber.Focus();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        //取消关闭当前窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
