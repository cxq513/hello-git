using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmPwdQuestionANDPwd : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象
        public FrmPwdQuestionANDPwd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            //数据验证
            if (this.combPwdQuestion.SelectedIndex == -1)
            {
                MessageBox.Show("请选择密保问题！", "信息提示");
                this.txtUserPwd.Focus();
                return;
            }
            if (this.txtPwdAnswer.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密保答案！", "信息提示");
                this.txtUserPwd.Focus();
                return;
            }
            if (this.txtUserPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "信息提示");
                this.txtUserPwd.Focus();
                return;
            }
            //判断是否存在用户名以及密保问题和答案是否一致
            if (this.objUserService.IsUserPwdAndQuestionExisted(Program.currentUser.UserName, Commons.EncodeHelper.AES_Encrypt(txtUserPwd.Text.Trim()), this.combPwdQuestion.Text.Trim(), txtPwdAnswer.Text.Trim()))
            {
                MessageBox.Show("密码不正确或密保答案不正确！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserPwd.Focus();
                this.txtUserPwd.SelectAll();
                return;
            }
            //获取要删除的学号
            string UserName = Program.currentUser.UserName;
            //根据学号删除
            try
            {
                if (objUserService.DeleteUser(UserName) == 1 && objUserService.DeleteUserLogin(UserName) == 1)
                {
                    MessageBox.Show("注销成功！", "注销提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "注销信息");
            }

            System.Environment.Exit(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
