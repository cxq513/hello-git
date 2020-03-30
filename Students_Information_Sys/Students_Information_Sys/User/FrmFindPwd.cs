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
    public partial class FrmFindPwd : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmFindPwd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            //数据验证
            if (this.txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！", "信息提示");
                this.txtUserName.Focus();
                return;
            }
            if (this.combPwdQuestion.SelectedIndex == 0)
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
                MessageBox.Show("请输入新密码！", "信息提示");
                this.txtUserPwd.Focus();
                return;
            }
            if (this.txtUserPwd.Text != txtPwdAgin.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "信息提示");
                this.txtUserPwd.Focus();
                return;
            }            
            //判断是否存在用户名以及密保问题和答案是否一致
            if (this.objUserService.IsUserExisted(this.txtUserName.Text.Trim(), this.combPwdQuestion.Text.Trim(),txtPwdAnswer.Text.Trim()))
            {
                MessageBox.Show("用户名不存在或密保答案不正确！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserName.Focus();
                this.txtUserName.SelectAll();
                return;
            }
            //将新密码提交到数据库
            int result = objUserService.PwdUpdate(txtUserName.Text.Trim(), Commons.EncodeHelper.AES_Encrypt(this.txtUserPwd.Text.Trim()));
            if (result == 1)
            {
                MessageBox.Show("新密码修改成功！", "修改提示");
                //Program.currentUser.UserPwd = Commons.EncodeHelper.AES_Encrypt(this.txtUserPwd.Text.Trim());
                this.Close();
            }
        }
        //取消关闭当前窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
