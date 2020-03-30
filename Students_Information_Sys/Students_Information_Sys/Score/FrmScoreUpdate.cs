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
    public partial class FrmScoreUpdate : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();
        private ScoreService objScoreService = new ScoreService();

        public FrmScoreUpdate()
        {
            InitializeComponent();
        }

        public FrmScoreUpdate(Score objScore)
        {
            InitializeComponent();

            txtStudentNameAndNumber.Text = objScore.StudentNameAndNumber.ToString();
            txtClassName.Text = objScore.ClassName.ToString();
            txtSemester.Text = objScore.Semester.ToString();
            txtCourseName.Text = objScore.CourseName.ToString();
            txtScoer_.Text = objScore.Score_.ToString();
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            if (txtScoer_.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生姓名！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtScoer_.Focus();
                return;
            }
            //封装成绩
            Score objScore = new Score()
            {
                StudentNameAndNumber = txtStudentNameAndNumber.Text.ToString(),
                ClassName = txtClassName.Text.Trim(),
                Semester = txtSemester.Text.Trim(),
                CourseName = txtCourseName.Text.Trim(),
                Score_ = Convert.ToInt32(txtScoer_.Text.Trim())
            };

            //提交对象
            //判断是否保存成功
            try
            {
                int result = objScoreService.UpdateScore(objScore);
                if (result == 1)
                {
                    MessageBox.Show("成绩修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    this.txtScoer_.Focus();
                }
                else
                {
                    MessageBox.Show("成绩修改失败！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //取消关闭当前窗口 
        private void btnExit_Click(object sender, EventArgs e)
        {
            //取消关闭当前窗口 
        }
    }
}
