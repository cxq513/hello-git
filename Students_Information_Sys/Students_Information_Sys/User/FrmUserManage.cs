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
    public partial class FrmUserManage : DockContent
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmUserManage()
        {
            InitializeComponent();
            //显示当前用户名
            txtUserName.Text = Program.currentUser.UserName;
            //显示注册时间
            User objUser = objUserService.SelectUserRegisterTime(Program.currentUser.UserName);
            dtpRegisterTime.Text = objUser.RegisterTime.ToString();


            //显示上次登录时间
            UserExt objUserExt = objUserService.SelectUserLoginTime(Program.currentUser.UserName);
            dtpLoginTime.Text = objUserExt.LoginTime.ToString();

        }
        //定义打开页面
        private void OpenForm(DockContent frm)
        {
            FrmMain main = (FrmMain)this.Parent.Parent.Parent.Parent;
            main.IsMdiContainer = true;
            frm.MdiParent = main;
            frm.Show(main.dockPanel1);
        }

        //修改密码按钮
        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            FrmPwdUpdate objPwdUpdate = new FrmPwdUpdate();
            DialogResult result = objPwdUpdate.ShowDialog();
        }

        //注销用户
        private void pwdDeleteUser_Click(object sender, EventArgs e)
        {
            //删除确认
            DialogResult result = MessageBox.Show("一旦注销将不再享有登录权并且退出程序！是否继续？", "注销确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;

            FrmPwdQuestionANDPwd objPwdQuestionANDPwd = new FrmPwdQuestionANDPwd();
            DialogResult result1 = objPwdQuestionANDPwd.ShowDialog();
        }

        private void btnUpdateUserName_Click(object sender, EventArgs e)
        {
            FrmUpdateUserName objUpdateForm = new FrmUpdateUserName();
            DialogResult result = objUpdateForm.ShowDialog();
        }

        private void btnUpdatePwdQuestion_Click(object sender, EventArgs e)
        {
            FrmAnswerPwdQuestion objAnswerPwdQuestion = new FrmAnswerPwdQuestion();
            DialogResult result = objAnswerPwdQuestion.ShowDialog();
        }
    }
}
