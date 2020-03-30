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
using System.Data.SqlClient;

namespace Students_Information_Sys
{
    public partial class FrmScoreAdd : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();
        private ScoreService objScoreService = new ScoreService();

        public FrmScoreAdd()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objScoreService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
            combCollageName.Text = null;
        }

        /// <summary>
        /// 根据学院查询专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSemester.Clear();
            txtStudentName.Clear();
            txtCourseName.Clear();
            txtScore.Clear();
            lvCourseName.Clear();
            lvStudentName.Clear();
            combSemester.DataSource = null;
            if (combCollageName.SelectedValue != null && combCollageName.DataSource != null)
            {
                this.combSpecialityName.DisplayMember = "SpecialityName";
                this.combSpecialityName.ValueMember = "SpecialityID";
                this.combSpecialityName.DataSource = objScoreService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
                this.combSpecialityName.SelectedIndexChanged += new System.EventHandler(this.combSpecialityName_SelectedIndexChanged);
                combSpecialityName.Text = null;
            }
            else
            {
                this.combSpecialityName.DataSource = null;
            }
        }

        /// <summary>
        /// 根据专业ID查询班级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combSpecialityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSemester.Clear();
            txtStudentName.Clear();
            txtCourseName.Clear();
            txtScore.Clear();
            combSemester.DataSource = null;
            lvCourseName.Clear();
            lvStudentName.Clear();
            if (combSpecialityName.SelectedValue != null && combSpecialityName.DataSource != null)
            {
                if (combSpecialityName.Text == "" || combSpecialityName.Text == null)
                {
                    combClassName.DataSource = null;
                }
                else
                {
                    this.combClassName.DisplayMember = "ClassName";
                    this.combClassName.ValueMember = "ClassID";
                    this.combClassName.DataSource = objScoreService.GetClassNameBySpecialityID(combSpecialityName.SelectedValue.ToString()).Tables[0].DefaultView;
                    this.combClassName.SelectedIndexChanged += new System.EventHandler(this.combClassName_SelectedIndexChanged);
                    combClassName.Text = null;
                }

            }

            else
            {
                combClassName.DataSource = null;
            }
        }

        /// <summary>
        /// 根据班级查询学期 并显示学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSemester.Clear();
            txtStudentName.Clear();
            txtCourseName.Clear();
            txtScore.Clear();
            lvCourseName.Clear();
            lvStudentName.Clear();
            if (combClassName.SelectedValue != null && combClassName.DataSource != null)
            {
                if (combClassName.Text == "" || combClassName.Text == null)
                {
                    combSemester.DataSource = null;
                }
                else
                {
                    this.combSemester.DisplayMember = "Semester";
                    this.combSemester.ValueMember = "ClassID";
                    this.combSemester.DataSource = objScoreService.GetSemesterByClassName(combClassName.SelectedValue.ToString()).Tables[0].DefaultView;
                    combSemester.Text = null;

                    lvStudentName.Clear();

                    string sql = "SELECT StudentName, StudentNumber, StudentPhoto FROM tbStudentInfo WHERE ClassID ='" + combClassName.SelectedValue.ToString() + "'";
                    SqlDataReader objReader = SQLHelper.GetReader(sql);
                    while (objReader.Read())
                    {
                        this.lvStudentName.LargeImageList = this.imageList1;
                        ListViewItem item = new ListViewItem();
                        item.Text = objReader.GetString(0) + "(" + objReader.GetString(1) + ")";
                        item.Tag = objReader.GetString(1);
                        item.ImageIndex = 0;
                        lvStudentName.Items.Add(item);
                    }
                    objReader.Close();
                }
            }
            else
            {
                combSemester.DataSource = null;
                lvStudentName.Clear();
            }

        }

        /// <summary>
        /// 根据学期 显示课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSemester.Clear();
            txtStudentName.Clear();
            txtCourseName.Clear();
            txtScore.Clear();
            lvCourseName.Clear();
            if (combSemester.SelectedValue != null && combSemester.DataSource != null)
            {
                if (combSemester.Text == "" || combSemester.Text == null)
                {
                    txtSemester.Clear();
                    lvCourseName.Items.Clear();
                }
                else
                {
                    lvCourseName.Clear();
                    txtSemester.Clear();

                    txtSemester.Text = combSemester.Text;


                    string sql = "SELECT CourseName FROM tbCourseInfo WHERE Semester ='" + combSemester.Text + "'AND ClassName='" + combClassName.Text + "'";
                    SqlDataReader objReader = SQLHelper.GetReader(sql);
                    while (objReader.Read())
                    {
                        this.lvCourseName.LargeImageList = this.imageList2;
                        ListViewItem item = new ListViewItem();
                        item.Text = objReader.GetString(0);
                        item.ImageIndex = 0;
                        lvCourseName.Items.Add(item);
                    }
                    objReader.Close();
                }
            }
            else
            {
                txtSemester.Clear();
                lvCourseName.Clear();
            }
        }

        /// <summary>
        /// 把选中的学生显示到txtStudentName中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentName.Text = lvStudentName.Items[lvStudentName.FocusedItem.Index].Text.Trim();
            txtStudentName.Tag = lvStudentName.Items[lvStudentName.FocusedItem.Index].Tag;
        }

        /// <summary>
        /// 把选中的课程显示到txtCourseName中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCourseName.Clear();
            txtCourseName.Text = lvCourseName.Items[lvCourseName.FocusedItem.Index].Text.Trim();
            
        }

        /// <summary>
        /// 添加分数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtSemester.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择学期！", "添加提示");
                this.txtSemester.Focus();
                return;
            }
            if (txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择学生！", "添加提示");
                this.txtStudentName.Focus();
                return;
            }
            if (txtCourseName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择课程！", "添加提示");
                this.txtCourseName.Focus();
                return;
            }
            if (txtScore.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写成绩！", "添加提示");
                this.txtScore.Focus();
                return;
            }
            if (this.objScoreService.IsScoreExisted(this.txtCourseName.Text.Trim(), txtStudentName.Tag.ToString(), txtSemester.Text.Trim())) 
            {
                MessageBox.Show("该学生本学期此课程已录入成绩！", "添加提示");
                this.txtScore.Focus();
                this.txtScore.SelectAll();
                return;
            }
            //封装课程对象
            Score objScore = new Score()
            {
                ClassName = combClassName.Text.Trim(),
                Semester = txtSemester.Text.Trim(),
                StudentNumber = txtStudentName.Tag.ToString(),
                Score_ = Convert.ToInt32(txtScore.Text.Trim()),
                CourseName = txtCourseName.Text.Trim(),
                StudentNameAndNumber = txtStudentName.Text.Trim()

            };
            //提交对象

            try
            {
                int result = objScoreService.AddScoer(objScore);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("添加成功！是否继续添加", "添加询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //清空当前的文本框
                        //初始化专业下拉框
                        txtScore.Clear();
                        txtScore.Focus();
                        this.txtScore.SelectAll();
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
        //取消关闭当前窗口  
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 回车添加成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtScore.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnok_Click(null, null);
            }
        }

        /// <summary>
        /// 鼠标单击lvStudentName时txtScore被选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvStudentName_MouseUp(object sender, MouseEventArgs e)
        {
            txtScore.Focus();
            this.txtScore.SelectAll();
        }
    }
}
