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
    public partial class FrmCourseUpdate : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();


        public FrmCourseUpdate()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            //this.combCollageName.SelectedIndex = -1;
            combCollageName.Text = null;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);

        }

        /// <summary>
        /// 根据学院查询专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            combSpecialityName.DataSource = null;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            //this.combSpecialityName.SelectedIndex = -1;
            combSpecialityName.Text = null;
            this.combSpecialityName.SelectedIndexChanged += new System.EventHandler(this.combSpecialityName_SelectedIndexChanged);

        }

        /// <summary>
        /// 根据专业ID查询班级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combSpecialityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combSpecialityName.DataSource != null)
            {
                combClassName.DataSource = null;
                this.combClassName.DataSource = objStudentService.GetClassNameBySpecialityID(combSpecialityName.SelectedValue.ToString()).Tables[0].DefaultView;
                this.combClassName.DisplayMember = "ClassName";
                this.combClassName.ValueMember = "ClassID";
                //this.combClassName.SelectedIndex = -1;
                combClassName.Text = "";
                this.combClassName.SelectedIndexChanged += new System.EventHandler(this.combClassName_SelectedIndexChanged);
            }
            else
            {
                combClassName.DataSource = null;
            }
            dtpEnrolmentTime.Value = DateTime.Today;
        }

        /// <summary>
        /// 根据班级查询入学时间和学期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combClassName.DataSource != null)
            {
                if (combClassName.Text == null || combClassName.Text == "")
                {
                    combSemester.DataSource = null;
                    dtpEnrolmentTime.Value = DateTime.Today;
                }
                else
                {

                    combSemester.DataSource = null;
                    combCourseName.DataSource = null;
                    this.combSemester.DisplayMember = "Semester";
                    this.combSemester.ValueMember = "ClassID";
                    this.combSemester.DataSource = objCourseService.GetSemesterForUpdate(combClassName.SelectedValue.ToString()).Tables[0].DefaultView;
                    //this.combSemester.SelectedIndex = -1;
                    combSemester.Text = null;
                    this.combSemester.SelectedIndexChanged += new System.EventHandler(this.combSemester_SelectedIndexChanged);

                    if (combClassName.Text == null || combClassName.Text == "" || combClassName.Text == "System.Data.DataRowView")
                    {
                        dtpEnrolmentTime.Value = DateTime.Today;
                    }
                    else
                    {
                        Class objClass = objCourseService.GetEnrolmentTime(combClassName.Text);
                        this.dtpEnrolmentTime.Text = objClass.EnrolmentTime.ToString();
                    }
                }
            }
            else
            {
                dtpEnrolmentTime.Value = DateTime.Today;
                combSemester.DataSource = null;
                combCourseName.DataSource = null;
            }
        }

        /// <summary>
        /// 通过学期查询课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combSemester.DataSource != null)
            {
                this.combCourseName.DisplayMember = "CourseName";
                this.combCourseName.ValueMember = "CourseID";
                this.combCourseName.DataSource = objCourseService.GetCourseNameForUpdate(combSemester.Text,combClassName.Text).Tables[0].DefaultView;
                //this.combCourseName.SelectedIndex = -1;
                combCourseName.Text = null;
                this.combCourseName.SelectedIndexChanged += new System.EventHandler(this.combCourseName_SelectedIndexChanged);
            }
            else
            {
                combCourseName.Text = null;
                combCourseName.Text = "";
                combCourseName.DataSource = null;
            }
        }

        /// <summary>
        /// 根据课程显示课程信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCourseName.Text == null || combCourseName.Text == "" || combCourseName.Text == "System.Data.DataRowView")
            {
                txtTeacher.Clear();
                txtTeacherPhoneNumber.Clear();
            }
            if (combClassName.Text == null || combClassName.Text == "" || combClassName.Text == "System.Data.DataRowView")
            {
                txtTeacher.Clear();
                txtTeacherPhoneNumber.Clear();
            }
            if (combSemester.Text == null || combSemester.Text == "" || combSemester.Text == "System.Data.DataRowView")
            {
                txtTeacher.Clear();
                txtTeacherPhoneNumber.Clear();
            }
            if (combCourseName.DataSource != null && combCourseName.Text != null && combCourseName.Text != "" && combCourseName.Text != "System.Data.DataRowView")
            {
                Course objCourse = objCourseService.GetCourse(combCourseName.Text, combClassName.Text, combSemester.Text);
                if (objCourse != null)
                {
                    txtTeacher.Text = objCourse.Teacher.ToString();
                    txtTeacherPhoneNumber.Text = objCourse.TeacherPhoneNumber.ToString();
                }
                else
                {
                    txtTeacher.Clear();
                    txtTeacherPhoneNumber.Clear();
                }
            }
            else
            {
                txtTeacher.Clear();
                txtTeacherPhoneNumber.Clear();
            }
        }

        /// <summary>
        /// 修改课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (combCollageName.Text.Trim() == "")
            {
                MessageBox.Show("请选择学院", "修改提示");
            }
            if (combSpecialityName.Text.Trim() == "")
            {
                MessageBox.Show("请选择学专业", "修改提示");
            }
            if (combClassName.Text.Trim() == "")
            {
                MessageBox.Show("请选择班级", "修改提示");
            }
            if (combSemester.Text.Trim() == "")
            {
                MessageBox.Show("请选择学期", "修改提示");
            }
            if (txtTeacher.Text.Trim() == "")
            {
                MessageBox.Show("请填写任课教师", "修改提示");
            }
            if (this.objCourseService.IsCourseExisted(this.combCourseName.Text.Trim(), combSemester.Text.Trim(), combClassName.Text.Trim()))
            {
                MessageBox.Show("该班级本学期已经存在此课程！", "添加提示");
                this.txtTeacher.Focus();
                this.txtTeacher.SelectAll();
                return;
            }
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
                    this.combCollageName.Focus();
                }
                else
                {
                    MessageBox.Show("课程信息修改失败！", "添加提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
