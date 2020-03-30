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
    public partial class FrmScoreBrowse : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        private CourseService objCourseService = new CourseService();
        private ScoreService objScoreService = new ScoreService();

        List<Score> list = null;
        List<ScoreExt> list1 = null;

        /// <summary>
        /// 窗体初始化
        /// </summary>
        public FrmScoreBrowse()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objScoreService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
            combCollageName.Text = null;
            dgvClassScore.DataSource = null;
            dgvStudentScore.DataSource = null;

        }

        /// <summary>
        /// 根据学院查询专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAvgScore.Clear();
            txtMaxScore.Clear();
            txtMinScore.Clear();
            txtCanKao.Clear();
            txtQueKao.Clear();
            dgvClassScore.DataSource = null;
            dgvStudentScore.DataSource = null;
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
            txtAvgScore.Clear();
            txtMaxScore.Clear();
            txtMinScore.Clear();
            txtCanKao.Clear();
            txtQueKao.Clear();
            dgvClassScore.DataSource = null;
            dgvStudentScore.DataSource = null;
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
            txtAvgScore.Clear();
            txtMaxScore.Clear();
            txtMinScore.Clear();
            txtCanKao.Clear();
            txtQueKao.Clear();
            dgvClassScore.DataSource = null;
            dgvStudentScore.DataSource = null;
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
            txtAvgScore.Clear();
            txtMaxScore.Clear();
            txtMinScore.Clear();
            txtCanKao.Clear();
            txtQueKao.Clear();
            dgvClassScore.DataSource = null;
            dgvStudentScore.DataSource = null;
            lvCourseName.Clear();
            if (combSemester.SelectedValue != null && combSemester.DataSource != null)
            {
                if (combSemester.Text == "" || combSemester.Text == null)
                {
                    lvCourseName.Items.Clear();
                }
                else
                {
                    lvCourseName.Clear();


                    string sql = "SELECT CourseName FROM tbCourseInfo WHERE Semester ='" + combSemester.Text + "'AND ClassName='" + combClassName.Text + "'";
                    SqlDataReader objReader = SQLHelper.GetReader(sql);
                    while (objReader.Read())
                    {
                        this.lvCourseName.LargeImageList = this.imageList2;
                        ListViewItem item = new ListViewItem();
                        item.Text = objReader.GetString(0);
                        for (int i = 0; i <= lvCourseName.Items.Count; i++)  
                        {
                            item.ImageIndex = i;
                        }
                        lvCourseName.Items.Add(item);
                    }
                    objReader.Close();
                }
            }
            else
            {
                lvCourseName.Clear();
            }
        }

        /// <summary>
        /// 显示学生成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAvgScore.Clear();
            txtMaxScore.Clear();
            txtMinScore.Clear();
            txtCanKao.Clear();
            txtQueKao.Clear();
            list1 = objScoreService.GetStudentScore(lvStudentName.Items[lvStudentName.FocusedItem.Index].Tag.ToString(), combSemester.Text, combClassName.Text);
            this.dgvStudentScore.AutoGenerateColumns = false;
            this.dgvStudentScore.DataSource = list1;
        }

        /// <summary>
        /// 显示班级单科目成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = objScoreService.GetClassScore(lvCourseName.Items[lvCourseName.FocusedItem.Index].Text.Trim(), combSemester.Text,combClassName.Text);
            this.dgvClassScore.AutoGenerateColumns = false;
            this.dgvClassScore.DataSource = list;

            try
            {
                //查询平均成绩，最高成绩，最低成绩
                Dictionary<string, string> dic = objScoreService.GetScoreInfo(combClassName.Text, combSemester.Text, lvCourseName.Items[lvCourseName.FocusedItem.Index].Text.Trim());
                txtAvgScore.Text = dic["avgScore_"];
                txtMaxScore.Text = dic["maxScore_"];
                txtMinScore.Text = dic["minScore_"];
                txtCanKao.Text = dic["countStndentNumber"];
                txtQueKao.Text = dic["absentCOUNT"];
            }
            catch (Exception EX)
            {

                throw EX;
            }

            //显示缺考学生姓名
            List<string> list3 = objScoreService.GetAbsentList(combClassName.Text, combSemester.Text, lvCourseName.Items[lvCourseName.FocusedItem.Index].Text.Trim());
            listAbsentStudentName.Items.Clear();
            listAbsentStudentName.Items.AddRange(list3.ToArray());
        }

        /// <summary>
        /// 学生成绩升序排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (list1 == null || dgvStudentScore.RowCount == 0) return;
            list1.Sort(new ScoreASCStu());
            this.dgvStudentScore.DataSource = null;
            dgvStudentScore.DataSource = list1;
        }

        /// <summary>
        /// 学生成绩降序排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (list1 == null || dgvStudentScore.RowCount == 0) return;
            list1.Sort(new ScoreDESCStu());
            this.dgvStudentScore.DataSource = null;
            dgvStudentScore.AutoGenerateColumns = false;
            dgvStudentScore.DataSource = list1;
        }

        /// <summary>
        /// 班级成绩升序排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClassUp_Click(object sender, EventArgs e)
        {
            if (list == null || dgvClassScore.RowCount == 0) return;
            list.Sort(new ScoreASC());
            this.dgvClassScore.DataSource = null;
            dgvClassScore.AutoGenerateColumns = false;
            dgvClassScore.DataSource = list;
        }

        /// <summary>
        /// 班级成绩降序排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClassDown_Click(object sender, EventArgs e)
        {
            if (list == null || dgvClassScore.RowCount == 0) return;
            list.Sort(new ScoreDESC());
            this.dgvClassScore.DataSource = null;
            dgvClassScore.DataSource = list;
        }

        /// <summary>
        /// 修改学生成绩按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudentScore.RowCount == 0 || dgvStudentScore.CurrentRow == null) 
            {
                MessageBox.Show("没有要修改的对象!", "修改提示");
                return;
            }
            if (dgvStudentScore.CurrentRow == null)
            {
                MessageBox.Show("请选择要修改的对象!", "修改提示");
                return;
            }
            //获取要修改课程信息
            string StudentNameAndNumber = lvStudentName.Items[lvStudentName.FocusedItem.Index].Text.ToString();
            string ClassName = combClassName.Text.Trim();
            string Semester = combSemester.Text.Trim();
            string CourseName = this.dgvStudentScore.CurrentRow.Cells["CourseName"].Value.ToString();
            string Score_ = this.dgvStudentScore.CurrentRow.Cells["Score_"].Value.ToString();
            Score objScore = objScoreService.GetStudentScoreForUpdate(StudentNameAndNumber, ClassName, Semester, CourseName, Score_);
            //显示修改窗体
            FrmScoreUpdate objUpdateForm = new FrmScoreUpdate(objScore);
            DialogResult result = objUpdateForm.ShowDialog();
            //判断是否修改成功
            if (result == DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// 删除学生成绩按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudentScore.RowCount == 0)
            {
                MessageBox.Show("没有要删除的对象!", "删除提示");
                return;
            }
            if (dgvStudentScore.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的对象!", "删除提示");
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的课程信息
            string StudentNameAndNumber = lvStudentName.Items[lvStudentName.FocusedItem.Index].Text.ToString();
            string ClassName = combClassName.Text.Trim();
            string Semester = combSemester.Text.Trim();
            string CourseName = this.dgvStudentScore.CurrentRow.Cells["CourseName"].Value.ToString();
            string Score_ = this.dgvStudentScore.CurrentRow.Cells["Score_"].Value.ToString();
            Score objScore = objScoreService.GetStudentScoreForUpdate(StudentNameAndNumber, ClassName, Semester, CourseName, Score_);
            //根据信息删除
            try
            {
                if (objScoreService.DeleteScore(StudentNameAndNumber, ClassName, Semester, CourseName, Score_) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "删除信息");
            }
        }

        /// <summary>
        /// 导出学生成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintStuScore_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentScore.RowCount == 0 || this.dgvStudentScore.CurrentRow == null)
            {
                MessageBox.Show("没有要导出的信息！", "信息提示");
                return;
            }
            //调用Excle打印模板实现打印
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            Excel.Visible = true;

            for (int i = 0; i < dgvStudentScore.Columns.Count; i++)
            {
                Excel.Cells[1, i + 1] = dgvStudentScore.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvStudentScore.Rows.Count; i++)
            {
                for (int j = 0; j < dgvStudentScore.Columns.Count; j++)
                {
                    Excel.Cells[i + 2, j + 1] = dgvStudentScore.Rows[i].Cells[j].Value;
                }
            }
        }

        /// <summary>
        /// 导出班级成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintClassScore_Click(object sender, EventArgs e)
        {
            if (this.dgvClassScore.RowCount == 0 || this.dgvClassScore.CurrentRow == null)
            {
                MessageBox.Show("没有要导出的信息！", "信息提示");
                return;
            }
            //调用Excle打印模板实现打印
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            Excel.Visible = true;

            for (int i = 0; i < dgvClassScore.Columns.Count; i++)
            {
                Excel.Cells[1, i + 1] = dgvClassScore.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvClassScore.Rows.Count; i++)
            {
                for (int j = 0; j < dgvClassScore.Columns.Count; j++)
                {
                    Excel.Cells[i + 2, j + 1] = dgvClassScore.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}


/// <summary>
/// 班级成绩升序方法接口
/// </summary>
class ScoreASC : IComparer<Score>
{
    public int Compare(Score x, Score y)
    {
        return x.Score_.CompareTo(y.Score_);
    }
}

/// <summary>
/// 班级成绩降序方法接口
/// </summary>
class ScoreDESC : IComparer<Score>
{
    public int Compare(Score x, Score y)
    {
        return y.Score_.CompareTo(x.Score_);
    }
}

/// <summary>
/// 学生成绩升序方法接口
/// </summary>
class ScoreASCStu : IComparer<ScoreExt>
{
    public int Compare(ScoreExt x, ScoreExt y)
    {
        return x.Score_.CompareTo(y.Score_);
    }
}

/// <summary>
/// 学生成绩降序方法接口
/// </summary>
class ScoreDESCStu : IComparer<ScoreExt>
{
    public int Compare(ScoreExt x, ScoreExt y)
    {
        return y.Score_.CompareTo(x.Score_);
    }
}
