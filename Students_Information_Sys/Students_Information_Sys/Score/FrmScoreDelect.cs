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
    public partial class FrmScoreDelect : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();
        private ScoreService objScoreService = new ScoreService();
        
        public FrmScoreDelect()
        {
            InitializeComponent();
        }

        public FrmScoreDelect(Score objScore)
        {
            InitializeComponent();

            txtStudentNameAndNumber.Text = objScore.StudentNameAndNumber.ToString();
            txtClassName.Text = objScore.ClassName.ToString();
            txtSemester.Text = objScore.Semester.ToString();
            txtCourseName.Text = objScore.CourseName.ToString();
            txtScoer_.Text = objScore.Score_.ToString();
        }
        //取消关闭当前窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
