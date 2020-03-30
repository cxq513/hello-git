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
    public partial class FrmPwdUpdate : DockContent
    {
        private UserService objUserService = new UserService();

        public FrmPwdUpdate()
        {
            InitializeComponent();
        }

        //修改密码
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //校验用户输入的就密码是否正确
            if (this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原密码！", "修改提示");
                this.txtOldPwd.Focus();
                return;
            }
            //判断原密码是否正确
            if (Commons.EncodeHelper.AES_Encrypt(this.txtOldPwd.Text.Trim()) != Program.currentUser.UserPwd) 
            {
                MessageBox.Show("原密码不正确！", "修改提示");
                this.txtOldPwd.Focus();
                this.txtOldPwd.SelectAll();
                return;
            }
            //判断用户是否输入新密码
            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新密码！", "修改提示");
                this.txtNewPwd.Focus();
                return;
            }
            //判断两次输入的新密码是否一致
            if (this.txtNewPwd.Text.Trim() != this.txtRNewPwd.Text.Trim()) 
            {
                MessageBox.Show("两次输入的新密码不一致！", "修改提示");
                this.txtRNewPwd.Focus();
                this.txtRNewPwd.SelectAll();
                return;
            }
            //将新密码提交到数据库
            int result = objUserService.PwdUpdate(Program.currentUser.UserName.ToString(), Commons.EncodeHelper.AES_Encrypt(this.txtNewPwd.Text.Trim()));
            if (result == 1)
            {
                MessageBox.Show("新密码修改成功！","修改提示");
                Program.currentUser.UserPwd = Commons.EncodeHelper.AES_Encrypt(this.txtNewPwd.Text.Trim());
                this.Close();
            }
        }
        //取消关闭当前窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
