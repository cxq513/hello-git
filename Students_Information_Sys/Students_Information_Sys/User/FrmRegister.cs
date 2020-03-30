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
    public partial class FrmRegister : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmRegister()
        {
            InitializeComponent();
        }

        //注册按钮
        private void btnOk_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！", "注册提示");
                this.txtUserName.Focus();
                return;
            }
            if (this.txtUserPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "注册提示");
                this.txtUserPwd.Focus();
                return;
            }
            if (this.txtUserPwd.Text != txtPwdAgin.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "注册提示");
                this.txtUserPwd.Focus();
                return;
            }
            if (this.combPwdQuestion.SelectedIndex == -1)
            {
                MessageBox.Show("请选择密保问题！", "注册提示");
                this.txtUserPwd.Focus();
                return;
            }
            if (this.txtPwdAnswer.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密保答案！", "注册提示");
                this.txtUserPwd.Focus();
                return;
            }
            //判断用户名是否存在
            if (this.objUserService.IsUserNameExisted(this.txtUserName.Text.Trim()))
            {
                MessageBox.Show("用户名已经存在！", "注册提示");
                this.txtUserName.Focus();
                this.txtUserName.SelectAll();
                return;
            }



            //封装用户信息到用户对象
            User objUser = new User()
            {
                RegisterTime = DateTime.Today,
                UserName = this.txtUserName.Text.Trim(),
                UserPwd = Commons.EncodeHelper.AES_Encrypt(this.txtUserPwd.Text.Trim()),
                PwdQuestion = this.combPwdQuestion.Text.Trim(),
                PwdAnswer = txtPwdAnswer.Text.Trim()
            };
            try
            {
                int result = objUserService.AddUser(objUser);
                if (result == 1)
                {

                    //封装用户名到存储COMBBOX中
                    UserExt objUserExt = new UserExt()
                    {
                        UserName = this.txtUserName.Text.Trim()
                    };
                    objUserService.AddUserLogin(objUserExt);

                    //更新用户登录时间
                    UserExt userExt = new UserExt()
                    {
                        LoginTime = DateTime.Today,
                        UserName = txtUserName.Text.Trim()
                    };
                    objUserService.UpdateLoginTime(userExt);

                    DialogResult dresult = MessageBox.Show("注册成功！请妥善保存您的密码", "注册提示", MessageBoxButtons.OK);
                    if (dresult == DialogResult.OK)
                    {

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("注册失败！", "添加提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
        //取消关闭当前窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
