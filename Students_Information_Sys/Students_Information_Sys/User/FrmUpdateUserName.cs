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
using WeifenLuo.WinFormsUI.Docking;

namespace Students_Information_Sys
{
    public partial class FrmUpdateUserName : DockContent
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmUpdateUserName()
        {
            InitializeComponent();
            //显示当前用户名
            txtUserName.Text = Program.currentUser.UserName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //判断信息是否为空

            if (txtNewUserName.Text.Trim() == null)
            {
                MessageBox.Show("请填写新用户名！", "修改提示");
                this.txtNewUserName.Focus();
                return;
            }
            //判断是否存在用户名
            if (objUserService.IsUserNameExisted(txtNewUserName.Text.Trim()) && objUserService.IsUserNameLogin(txtNewUserName.Text.Trim())) 
            {
                MessageBox.Show("用户名已存在！", "修改提示");
                this.txtNewUserName.Focus();
                return;
            }
            //提交对象
            //判断是否保存成功
            try
            {
                int result = objUserService.UpdateUserName(txtUserName.Text.Trim(), txtNewUserName.Text.Trim());
                int result1 = objUserService.UpdateUserLoginName(txtUserName.Text.Trim(), txtNewUserName.Text.Trim());
                if (result == 1 && result == 1)
                {
                    MessageBox.Show("用户名修改成功！请重新登录", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    //更新用户登录时间
                    UserExt userExt = new UserExt()
                    {
                        LoginTime = DateTime.Today,
                        UserName = txtNewUserName.Text.Trim()
                    };
                    objUserService.UpdateLoginTime(userExt);

                    System.Environment.Exit(0);

                }
                else
                {
                    MessageBox.Show("用户名修改失败", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objUserService.UpdateUserName(txtUserName.Text.Trim(), txtNewUserName.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
