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
    public partial class FrmCourseAdd : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();
        public FrmCourseAdd()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }

        /// <summary>
        /// 根据学院查询专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpEnrolmentTime.Value = DateTime.Today;
            combSemester.Text = "";
            combSemester.Text = null;
            combClassName.Text = "";
            combClassName.Text = null;
            combSpecialityName.Text = "";
            combSpecialityName.Text = null;
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.SelectedIndex = -1;
            this.combSpecialityName.SelectedIndexChanged += new System.EventHandler(this.combSpecialityName_SelectedIndexChanged);
        }

        /// <summary>
        /// 根据专业ID查询班级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combSpecialityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpEnrolmentTime.Value = DateTime.Today;
            combSemester.Text = "";
            combSemester.Text = null;
            combClassName.Text = "";
            combClassName.Text = null;
            this.combClassName.DisplayMember = "ClassName";
            this.combClassName.ValueMember = "ClassID";
            this.combClassName.DataSource = objClassService.GetClassNameBySpecialityID(combSpecialityName.SelectedValue.ToString()).Tables[0].DefaultView;
            combClassName.SelectedIndex = -1;
            this.combClassName.SelectedIndexChanged += new System.EventHandler(this.combClassName_SelectedIndexChanged);
        }

        /// <summary>
        /// 根据班级查询入学时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combClassName.Text == "" || combClassName.Text == null)
            {
                dtpEnrolmentTime.Value = DateTime.Today;
            }
            if (combCollageName.Text == "" || combCollageName.Text == null)
            {
                dtpEnrolmentTime.Value = DateTime.Today;
            }
            if (combSpecialityName.Text == "" || combSpecialityName.Text == null)
            {
                dtpEnrolmentTime.Value = DateTime.Today;
            }
            else
            {

                Class objClass = objCourseService.GetEnrolmentTime(this.combClassName.Text.Trim());
                this.dtpEnrolmentTime.Text = objClass.EnrolmentTime.ToString();

                int y = dtpEnrolmentTime.Value.Year;
                int m = dtpEnrolmentTime.Value.Month;
                int d = dtpEnrolmentTime.Value.Day;
                DateTime time;
                time = DateTime.Today;
                int a = time.Year;
                int b = time.Month;
                int c = time.Day;
                if ((y == a) && (m == b) && (c == d))
                {
                    this.combSemester.Text = null;
                }
                if (((y == a) && (9 <= m) && (m <= 12)) || (((y + 1 == a)) && (1 <= m) && (m <= 2)))
                {
                    this.combSemester.Text = "第一学年，第一学期";
                }
                else if ((y + 1 == a) && ((m >= 3) && (m <= 8)))
                {
                    this.combSemester.Text = "第一学年，第二学期";
                }
                else if (((y + 1 == a) && (9 <= m) && (m <= 12)) || ((y + 2 == a)) && ((1 <= m) && (m <= 2)))
                {
                    this.combSemester.Text = "第二学年，第一学期";
                }
                else if ((y + 2 == a) && ((m >= 3) && (m <= 8)))
                {
                    this.combSemester.Text = "第二学年，第二学期";
                }
                else if (((y + 2 == a) && (9 <= m) && (m <= 12)) || ((y + 3 == a)) && ((1 <= m) && (m <= 2)))
                {
                    this.combSemester.Text = "第三学年，第一学期";
                }
                else if ((y + 3 == a) && ((m >= 3) && (m <= 8)))
                {
                    this.combSemester.Text = "第三学年，第二学期";
                }
                else if (((y + 3 == a) && (9 <= m) && (m <= 12)) || ((y + 4 == a)) && ((1 <= m) && (m <= 2)))
                {
                    this.combSemester.Text = "第四学年，第一学期";
                }
                else if ((y + 4 == a) && ((m >= 3) && (m <= 8)))
                {
                    this.combSemester.Text = "第四学年，第二学期";
                }
                else if (((y + 4 == a) && (9 <= m) && (m <= 12)) || ((y + 5 == a)) && ((1 <= m) && (m <= 2)))
                {
                    this.combSemester.Text = "第五学年，第一学期";
                }
                else if ((y + 5 == a) && ((m >= 3) && (m <= 8)))
                {
                    this.combSemester.Text = "第五学年，第二学期";
                }
                else
                {
                    combSemester.Text = null;
                }
            }
        }


        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择专业！", "添加提示");
                this.combSpecialityName.Focus();
                return;
            }
            if (this.combClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "添加提示");
                this.combClassName.Focus();
                return;
            }
            if (txtCourseName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写课程名称！", "添加提示");
                this.txtCourseName.Focus();
                return;
            }
            if (txtTeacher.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写任课教师！", "添加提示");
                this.txtCourseName.Focus();
                return;
            }
            if (combSemester.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择学期！", "添加提示");
                this.combSemester.Focus();
                return;
            }
            if (this.objCourseService.IsCourseExisted(this.txtCourseName.Text.Trim(), combSemester.Text.Trim(), combClassName.Text.Trim()))
            {
                MessageBox.Show("该班级本学期已经存在此课程！", "添加提示");
                this.txtCourseName.Focus();
                this.txtCourseName.SelectAll();
                return;
            }
            //封装课程对象
            Course objCourse = new Course()
            {
                ClassName = combClassName.Text.Trim(),
                Semester = combSemester.Text.Trim(),
                CourseName = txtCourseName.Text.Trim(),
                ClassID = Convert.ToInt32(combClassName.SelectedValue),
                Teacher = txtTeacher.Text.Trim(),
                TeacherPhoneNumber = txtTeacherPhoneNumber.Text.Trim()
            };
            //提交对象

            try
            {
                int result = objCourseService.AddCourse(objCourse);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("添加成功！是否继续添加", "添加询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //清空当前的文本框
                        //初始化专业下拉框
                        combCollageName.Text = "";
                        txtCourseName.Text = "";
                        combSemester.Text = "";
                        combClassName.Text = "";
                        combSpecialityName.Text = "";
                        dtpEnrolmentTime.Value = DateTime.Today;
                        txtTeacherPhoneNumber.Text = "";
                        txtTeacher.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("添加失败！", "添加提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTeacherPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
                if (this.txtTeacherPhoneNumber.Text.Trim().Length == 0) return;
                if (e.KeyValue == 13)
                {
                    this.btnAdd_Click(null, null);
                    this.combCollageName.Focus();
                }
                if (e.KeyValue == 27)
                {
                    this.Close();
                }
        }
        //取消关闭当前窗口  
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
