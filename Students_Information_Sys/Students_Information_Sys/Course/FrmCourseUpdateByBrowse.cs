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
    public partial class FrmCourseUpdateByBrowse : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private CollageService objCollageService = new CollageService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();
        public FrmCourseUpdateByBrowse()
        {
            InitializeComponent();
        }
        public FrmCourseUpdateByBrowse(Course objCourse)
        {
            InitializeComponent();
            combClassName.Text = objCourse.ClassName.ToString();
            combSemester.Text = objCourse.Semester.ToString();
            combCourseName.Text = objCourse.CourseName.ToString();
            txtTeacher.Text = objCourse.Teacher.ToString();
            txtTeacherPhoneNumber.Text = objCourse.TeacherPhoneNumber.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            if (txtTeacher.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写任课教师！", "修改提示");
                this.txtTeacher.Focus();
                return;
            }
            if (txtTeacherPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写联系方式！", "修改提示");
                this.txtTeacherPhoneNumber.Focus();
                return;
            }

            //封装课程对象
            Course objCourse = new Course()
            {
                ClassName = combClassName.Text.Trim(),
                Semester = combSemester.Text.Trim(),
                CourseName = combCourseName.Text.Trim(),
                ClassID = Convert.ToInt32(combClassName.SelectedValue),
                Teacher = txtTeacher.Text.Trim(),
                TeacherPhoneNumber = txtTeacherPhoneNumber.Text.Trim()
            };
            //提交对象
            //判断是否保存成功
            try
            {
                int result = objCourseService.UpdateCourse(objCourse);
                if (result == 1)
                {
                    MessageBox.Show("课程信息修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    this.txtTeacher.Focus();

                }
                else
                {
                    MessageBox.Show("修改失败！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
