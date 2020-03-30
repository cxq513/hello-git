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
    public partial class FrmCourseBrowse : DockContent
    {
        private SpecialityService objSpecialityService = new SpecialityService();
        private CourseService objCourseService = new CourseService();
        private CollageService objCollageServicee = new CollageService();
        public FrmCourseBrowse()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 加载树目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCourseBrowse_Load(object sender, EventArgs e)
        {
            var list = objCourseService.GetCollageName();

            foreach (var CollageName in list)
            {
                var nod = new TreeNode();
                nod.Text = CollageName.CollageName.ToString();
                treeView1.Nodes.Add(nod);

                //获取专业名
                var list1 = objCourseService.GetSpecialitiesName(nod.Text.ToString());
                //加载专业根目录
                foreach (var SpecialityName in list1)
                {
                    var node = new TreeNode();
                    node.Text = SpecialityName.SpecialityName.ToString();
                    nod.Nodes.Add(node);
                    //获取班级名
                    var list2 = objCourseService.GetClassName(node.Text.ToString());
                    //加载班级子目录
                    foreach (var ClassName in list2)
                    {
                        var node1 = new TreeNode();
                        node1.Text = ClassName.ClassName.ToString();
                        node.Nodes.Add(node1);
                        //获取学期
                        var list3 = objCourseService.GetSemester(node1.Text.ToString());
                        //加载学期子目录
                        foreach (var Semester in list3)
                        {
                            var node2 = new TreeNode();
                            node2.Text = Semester.Semester.ToString();
                            node1.Nodes.Add(node2);
                            //获取课程
                            var list4 = objCourseService.GetCourseName(node2.Text.ToString(),node1.Text.ToString());
                            //加载课程子目录
                            foreach (var CourseName in list4)
                            {
                                var node3 = new TreeNode();
                                node3.Text = CourseName.CourseName.ToString();
                                node2.Nodes.Add(node3);
                                this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //定义课程信息集合 
            if (e.Node.Level == 4)
            {
                var list5 = objCourseService.GetCourseBag(e.Node.Text, e.Node.Parent.Text, e.Node.Parent.Parent.Text);
                this.dgvCourse.AutoGenerateColumns = false;
                this.dgvCourse.DataSource = list5;
            }
            if (e.Node.Level == 3)
            {
                var list6 = objCourseService.GetCourseBag1(e.Node.Text, e.Node.Parent.Text);
                this.dgvCourse.AutoGenerateColumns = false;
                this.dgvCourse.DataSource = list6;
            }
            if (e.Node.Level == 2)
            {
                var list7 = objCourseService.GetCourseBag2(e.Node.Text);
                this.dgvCourse.AutoGenerateColumns = false;
                this.dgvCourse.DataSource = list7;
            }
            if (e.Node.Level == 1)
            {
                this.dgvCourse.DataSource = null;
            }
            if (e.Node.Level == 0)
            {
                this.dgvCourse.DataSource = null;
            }

        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvCourse.RowCount == 0 || this.dgvCourse.CurrentRow == null)
            {
                MessageBox.Show("没有要修改的信息！", "修改");
                return;
            }
            //获取要修改学生的学号
            string CourseName = this.dgvCourse.CurrentRow.Cells["CourseName"].Value.ToString();
            string ClassName = this.dgvCourse.CurrentRow.Cells["ClassName"].Value.ToString();
            string Semester = this.dgvCourse.CurrentRow.Cells["Semester"].Value.ToString();
            Course objCourse = objCourseService.GetCourseByBrowse(CourseName,ClassName, Semester);
            //显示修改窗体
            FrmCourseUpdateByBrowse objUpdateForm = new FrmCourseUpdateByBrowse(objCourse);
            DialogResult result = objUpdateForm.ShowDialog();
            //判断是否修改成功
            if (result == DialogResult.OK)
            {
                FrmCourseBrowse_Load(null, null);
            }
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelect_Click(object sender, EventArgs e)
        {
            //判断信息
            if (dgvCourse.RowCount == 0)
            {
                MessageBox.Show("没有要删除的对象", "删除提示");
                return;
            }
            if (dgvCourse.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的对象", "删除提示");
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string CourseName = dgvCourse.CurrentRow.Cells["CourseName"].Value.ToString();
            string Semester = dgvCourse.CurrentRow.Cells["Semester"].Value.ToString();
            string ClassName = dgvCourse.CurrentRow.Cells["ClassName"].Value.ToString();
            //根据学号删除
            try
            {
                if (objCourseService.DeleteCourse(CourseName, Semester, ClassName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "删除信息");
            }
        }
        //退出 关闭当前窗口
        private void btnExie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
