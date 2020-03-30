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
using Models.Ext;

namespace Students_Information_Sys
{
    public partial class FrmStudentBrowse : DockContent
    {
        private StudentService objStudentService = new StudentService();
        private ClassService objClassService = new ClassService();
        //定义学生信息集合 
        List<StudentExt> list = null;
        public FrmStudentBrowse()
        {
            InitializeComponent();
            //动态填充班级下拉框
            this.combClassName.DataSource = objClassService.GetAllClass();
            this.combClassName.DisplayMember = "ClassName";
            this.combClassName.ValueMember = "ClassID";
            this.combClassName.SelectedIndex = -1;
        }

        //按照班级查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.combClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个班级","信息提示");
                this.combClassName.Focus();
                return;
            }
            list = objStudentService.GetStudentByClassID(this.combClassName.SelectedValue.ToString());
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.DataSource = list;
        }

        // 按照姓名升序排列
        private void btnNameUp_Click(object sender, EventArgs e)
        {
            if (list == null || dgvStudentList.RowCount == 0) return;
            list.Sort(new NameASC());//排序
            this.dgvStudentList.DataSource = null;//清空列表
            this.dgvStudentList.DataSource = list;//生成排序后的列表
        }

        // 按照姓名降序排列
        private void btnNameDown_Click(object sender, EventArgs e)
        {
            if (list == null || dgvStudentList.RowCount == 0) return;
            list.Sort(new NameDESC());//排序
            this.dgvStudentList.DataSource = null;//清空列表
            this.dgvStudentList.DataSource = list;//生成排序后的列表
        }

        // 按照学号升序排列
        private void lblStuNumberUp_Click(object sender, EventArgs e)
        {
            if (list == null || dgvStudentList.RowCount == 0) return;
            list.Sort(new StudentNumberASC());
            this.dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = list;
        }

        // 按照学号降序排列
        private void lblStuNumberDown_Click(object sender, EventArgs e)
        {
            if (list == null || dgvStudentList.RowCount == 0) return;
            list.Sort(new StudentNumberDESC());
            this.dgvStudentList.DataSource = null;
            dgvStudentList.DataSource = list;
        }

        //根据学号查询信息
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if (this.txtStudentNumber.Text.Trim().Length ==0)
            {
                MessageBox.Show("请输入要查询的学号！", "信息提示");
                this.txtStudentNumber.Focus();
                return;
            }
            //根据学号查询学院对象
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
                //创建学生信息展示窗体
                FrmStudentSearch objStudentSearchFrom = new FrmStudentSearch(objStudent);
                objStudentSearchFrom.Show();
            }
        }

        #region 回车查询 ，增加用户体验
        private void txtStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStudentNumber.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnSearch1_Click(null, null);
            }
        }
        private void combClassName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.combClassName.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnSearch_Click(null, null);
            }
        }




        #endregion

        /// <summary>
        /// 打印当前学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrinting_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0 || this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("没有要打印的信息！","打印提示");
                return;
            }
            //获取要修改的学生学号
            string StudentNumber = this.dgvStudentList.CurrentRow.Cells["StudentNumber"].Value.ToString();
            Student objStudent = objStudentService.GetStudent(StudentNumber);
            //调用Excle打印模板实现打印
            ExcelPrint objPrint = new ExcelPrint();
            objPrint.ExecutePrint(objStudent);
        }

        /// <summary>
        /// 打印班级学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintingClass_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0 || this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("没有要导出的信息！", "信息提示");
                return;
            }
            //调用Excle打印模板实现打印
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            Excel.Visible = true;

            for (int i = 0; i < dgvStudentList.Columns.Count; i++)
            {
                Excel.Cells[1, i + 1] = dgvStudentList.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvStudentList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvStudentList.Columns.Count; j++)
                {
                    Excel.Cells[i + 2, j + 1] = dgvStudentList.Rows[i].Cells[j].Value;
                }
            }

        }

        /// <summary>
        /// 修改当前学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0 || this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("没有要修改的信息！", "打印提示");
                return;
            }
            //获取要修改学生的学号
            string StudentNumber = this.dgvStudentList.CurrentRow.Cells["StudentNumber"].Value.ToString();
            Student objStudent = objStudentService.GetStudent(StudentNumber);
            //显示修改窗体
            FrmStudentUpdate objUpdateForm = new FrmStudentUpdate(objStudent );
            DialogResult result = objUpdateForm.ShowDialog();
            //判断是否修改成功
            if (result == DialogResult.OK)
            {
                btnSearch_Click(null, null);
            }
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //判断信息
            if (dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("没有要删除的对象","删除提示");
                return;
            }
            if (dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的对象", "删除提示");
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？","删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string StudentNumber = dgvStudentList.CurrentRow.Cells["StudentNumber"].Value.ToString();
            //根据学号删除
            try
            {
                if (objStudentService.DeleteStudent(StudentNumber) == 1)
                {
                    MessageBox.Show("删除成功！","删除提示");
                    btnSearch_Click(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"删除信息");
            }
        }

    }

    /// <summary>
    /// 按照姓名降序排列方法
    /// </summary>
    class NameDESC : IComparer<StudentExt>
    {
        public int Compare(StudentExt x, StudentExt y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }
    }

    /// <summary>
    /// 按照姓名升序排列方法
    /// </summary>
    class NameASC : IComparer<StudentExt>
    {
        public int Compare(StudentExt x, StudentExt y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }

    /// <summary>
    /// 按照学号降序排列方法
    /// </summary>
    class StudentNumberDESC : IComparer<StudentExt>
    {
        public int Compare(StudentExt x, StudentExt y)
        {
            return y.StudentNumber.CompareTo(x.StudentNumber);
        }
    }

    /// <summary>
    /// 按照学号升序排列方法
    /// </summary>
    class StudentNumberASC : IComparer<StudentExt>
    {
        public int Compare(StudentExt x, StudentExt y)
        {
            return x.StudentNumber.CompareTo(y.StudentNumber);
        }
    }
}
