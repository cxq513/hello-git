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
using System.Configuration;
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmMain : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象
        public static string UserName;
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 系统界面
        private void FrmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUserName.Text = "【当前用户：" + Program.currentUser.UserName + "】";
            toolStripStatusLabelVersion.Text = "版本号：" + ConfigurationManager.AppSettings["sysVersion"].ToString();
            FrmMenu menu = new FrmMenu();
            menu.Show(dockPanel1, DockState.DockLeft);
            dockPanel1.DockLeftPortion = 240;
            FrmHome home = new FrmHome();
            home.Show(dockPanel1);
        }
        #endregion

        #region 学生信息操作

        //添加学生信息
        private void ToolStripMenuItemStuAdd_Click(object sender, EventArgs e)
        {
            FrmStudentAdd add = new FrmStudentAdd();
            add.Show(dockPanel1);
        }
        //浏览学生信息
        private void 浏览学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentBrowse add = new FrmStudentBrowse();
            add.Show(dockPanel1);
        }
        //查找学生信息
        private void ToolStripMenuItemStuSearch_Click(object sender, EventArgs e)
        {
            FrmStudentSearch add = new FrmStudentSearch();
            add.Show(dockPanel1);
        }
        //更改学生信息
        private void ToolStripMenuItemStuUpDate_Click(object sender, EventArgs e)
        {
            FrmStudentUpdate add = new FrmStudentUpdate();
            add.Show(dockPanel1);
        }
        //删除学生信息
        private void ToolStripMenuItemStundentDelect_Click(object sender, EventArgs e)
        {
            FrmStudentDelect add = new FrmStudentDelect();
            add.Show(dockPanel1);
        }
        #endregion

        #region 成绩信息操作
        //添加成绩信息
        private void ToolStripMenuItemScoreAdd_Click(object sender, EventArgs e)
        {
            FrmScoreAdd add = new FrmScoreAdd();
            add.Show(dockPanel1);
        }
        //查询成绩信息
        private void ToolStripMenuItemScoreSearch_Click(object sender, EventArgs e)
        {
            FrmScoreSearch add = new FrmScoreSearch();
            add.Show(dockPanel1);
        }
        //更改成绩信息
        private void ToolStripMenuItemScoreUpdate_Click(object sender, EventArgs e)
        {
            FrmScoreUpdate add = new FrmScoreUpdate();
            add.Show(dockPanel1);
        }
        //删除成绩信息
        private void ToolStripMenuItemScoreDelect_Click(object sender, EventArgs e)
        {
            FrmScoreDelect add = new FrmScoreDelect();
            add.Show(dockPanel1);
        }
        //成绩信息查询与操作
        private void 浏览学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScoreBrowse add = new FrmScoreBrowse();
            add.Show(dockPanel1);
        }
        #endregion

        #region 专业信息操作

        //添加专业信息
        private void ToolStripMenuItemSpecialityAdd_Click(object sender, EventArgs e)
        {
            FrmSpecialityAdd add = new FrmSpecialityAdd();
            add.Show(dockPanel1);
        }
        //浏览专业信息
        private void ToolStripMenuItemSpecialityBrowse_Click(object sender, EventArgs e)
        {
            FrmSpecialityBrowse add = new FrmSpecialityBrowse();
            add.Show(dockPanel1);
        }
        //更改专业信息
        private void ToolStripMenuItemSpecialityUpdate_Click(object sender, EventArgs e)
        {
            FrmSpecialityUpdate add = new FrmSpecialityUpdate();
            add.Show(dockPanel1);
        }
        //删除专业信息
        private void ToolStripMenuItemSpecialityDelect_Click(object sender, EventArgs e)
        {
            FrmSpecialityDelect add = new FrmSpecialityDelect();
            add.Show(dockPanel1);
        }

        #endregion

        #region 班级信息操作
        //添加班级
        private void ToolStripMenuItemClassAdd_Click(object sender, EventArgs e)
        {
            FrmClassAdd add = new FrmClassAdd();
            add.Show(dockPanel1);
        }
        //浏览班级
        private void ToolStripMenuItemClassBrowse_Click(object sender, EventArgs e)
        {
            FrmClassBrowse add = new FrmClassBrowse();
            add.Show(dockPanel1);
        }
        //更改班级
        private void ToolStripMenuItemClassUpdate_Click(object sender, EventArgs e)
        {
            FrmClassUpdate add = new FrmClassUpdate();
            add.Show(dockPanel1);
        }
        //查询班级
        private void ToolStripMenuItem1ClassSearch_Click(object sender, EventArgs e)
        {
            FrmClassSearch add = new FrmClassSearch();
            add.Show(dockPanel1);
        }
        //删除班级
        private void ToolStripMenuItemClassDelect_Click(object sender, EventArgs e)
        {
            FrmClassDelect add = new FrmClassDelect();
            add.Show(dockPanel1);
        }

        #endregion

        #region 课程信息操作
        //添加课程信息
        private void ToolStripMenuItemAddCourseAdd_Click(object sender, EventArgs e)
        {
            FrmCourseAdd add = new FrmCourseAdd();
            add.Show(dockPanel1);
        }
        //浏览课程信息
        private void ToolStripMenuItemCourseBrowse_Click(object sender, EventArgs e)
        {
            FrmCourseBrowse add = new FrmCourseBrowse();
            add.Show(dockPanel1);
        }
        //修改课程信息
        private void ToolStripMenuItemUpdateCourseAdd_Click(object sender, EventArgs e)
        {
            FrmCourseUpdate add = new FrmCourseUpdate();
            add.Show(dockPanel1);
        }
        //删除课程信息
        private void ToolStripMenuItemDelete4CourseAdd_Click(object sender, EventArgs e)
        {
            FrmCourseDelete add = new FrmCourseDelete();
            add.Show(dockPanel1);
        }
        #endregion

        #region 系统操作

        //退出系统
        private void tuichuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //更新用户登录时间
            UserExt userExt = new UserExt()
            {
                LoginTime = DateTime.Today,
                UserName = Program.currentUser.UserName
            };
            objUserService.UpdateLoginTime(userExt);

            this.Close();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //更新用户登录时间
            UserExt userExt = new UserExt()
            {
                LoginTime = DateTime.Today,
                UserName = Program.currentUser.UserName
            };
            objUserService.UpdateLoginTime(userExt);

            DialogResult result = MessageBox.Show("确认退出吗？", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                

                e.Cancel = true;
            }
        }

        //更改密码
        private void ToolStripMenuItemPwdUpdate_Click(object sender, EventArgs e)
        {
            FrmPwdUpdate add = new FrmPwdUpdate();
            add.Show(dockPanel1);
        }




        #endregion

        #region 学院信息
        //添加学院
        private void ToolStripMenuItemCollageAdd_Click(object sender, EventArgs e)
        {
            FrmCollageAdd add = new FrmCollageAdd();
            add.Show(dockPanel1);
        }
        //浏览学院
        private void ToolStripMenuItemCollageBrowse_Click(object sender, EventArgs e)
        {
            FrmCollageBrowse add = new FrmCollageBrowse();
            add.Show(dockPanel1);
        }
        //删除学院
        private void ToolStripMenuItemCollageUpdate_Click(object sender, EventArgs e)
        {
            FrmCollageUpdate add = new FrmCollageUpdate();
            add.Show(dockPanel1);
        }
        //更改学院
        private void ToolStripMenuItemCollageDelete_Click(object sender, EventArgs e)
        {
            FrmCollageDelete add = new FrmCollageDelete();
            add.Show(dockPanel1);
        }




        #endregion


    }
}
