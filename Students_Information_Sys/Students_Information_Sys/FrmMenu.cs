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
using Models;
using DAL;

namespace Students_Information_Sys
{
    public partial class FrmMenu : DockContent
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            main.IsMdiContainer = true;
            frm.MdiParent = main;
            frm.Show(main.dockPanel1);
        }

        /// <summary>
        /// 打开学院浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCollageBrowse_Click(object sender, EventArgs e)
        {
            FrmCollageBrowse collageBrowse = new FrmCollageBrowse();
            OpenForm(collageBrowse);
        }

        /// <summary>
        /// 打开专业浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSpecialityBrowse_Click(object sender, EventArgs e)
        {
            FrmSpecialityBrowse specialityBrowse = new FrmSpecialityBrowse();
            OpenForm(specialityBrowse);
        }

        private void lblClassSerach_Click(object sender, EventArgs e)
        {
            FrmClassBrowse classBrowse = new FrmClassBrowse();
            OpenForm(classBrowse);
        }

        private void lblStudentSerach_Click(object sender, EventArgs e)
        {
            FrmStudentBrowse studentBrowse = new FrmStudentBrowse();
            OpenForm(studentBrowse);
        }

        private void lblCourseSearch_Click(object sender, EventArgs e)
        {
            FrmCourseBrowse courseBrowse = new FrmCourseBrowse();
            OpenForm(courseBrowse);
        }

        private void lblSorceSearch_Click(object sender, EventArgs e)
        {
            FrmScoreBrowse scoreBrowse = new FrmScoreBrowse();
            OpenForm(scoreBrowse);
        }

        private void lblPwdUpdate_Click(object sender, EventArgs e)
        {
            FrmPwdUpdate pwdUpdate = new FrmPwdUpdate();
            OpenForm(pwdUpdate);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            FrmUserManage UserManage = new FrmUserManage();
            OpenForm(UserManage);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //更新用户登录时间
                UserExt userExt = new UserExt()
                {
                    LoginTime = DateTime.Today,
                    UserName = Program.currentUser.UserName
                };
                objUserService.UpdateLoginTime(userExt);

                System.Environment.Exit(0);
            }
            else
            {
                return;
            }
            
        }


    }
}
