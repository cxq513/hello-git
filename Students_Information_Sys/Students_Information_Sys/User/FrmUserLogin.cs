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
using System.Configuration;

namespace Students_Information_Sys
{
    public partial class FrmUserLogin : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmUserLogin()
        {
            InitializeComponent();
            this.combUserID.DisplayMember = "UserName";
            this.combUserID.ValueMember = "UserName";
            this.combUserID.DataSource = objUserService.GetUserName().Tables[0].DefaultView;
            this.combUserID.Focus();
            //this.combUserID.SelectAll();
            //如果用户上次登录点击记住密码，本次登陆会加自动载用户密码，否则不加载用户密码
            //if (combUserID.Text.Trim() !="" && combUserID.Text.Trim() != null && combUserID.Text.Trim() !=  "System.Data.DataRowView")
            //{
            //    User user = objUserService.GetRemberPwd(combUserID.Text.Trim());
            //    txtRemberPwd.Text = user.RemberPwd.ToString();
            //    if (txtRemberPwd.Text == "1")
            //    {
            //        User userpwd = objUserService.GetUserPwd(combUserID.Text.Trim());
            //        txtUserPwd.Text = Commons.EncodeHelper.AES_Decrypt( userpwd.UserPwd.ToString());
            //        checkBoxRemberPwd.Checked = true;
            //    }
            //    if (txtRemberPwd.Text == "0")
            //    {
            //        txtUserPwd.Text = "";
            //    }
            //}

            //if (combUserID.Text.Trim() != "" && combUserID.Text.Trim() != null && combUserID.Text.Trim() != "System.Data.DataRowView")
            //{
            //    User user = objUserService.GetAutomaticlogon(combUserID.Text.Trim());
            //    txtAutomaticlogon.Text = user.Automaticlogon.ToString();
            //    if (txtAutomaticlogon.Text == "1")
            //    {
            //        btnLogon_Click(null, null);
            //    }
            //    if (txtAutomaticlogon.Text == "0")
            //    {
            //        txtUserPwd.Focus();
            //    }
            //}
           

        }
        //点击注册按钮时打开注册界面
        private void lblregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //打开注册口令界面
            FrmRegistrationPwd frm = new FrmRegistrationPwd();
            frm.ShowDialog();
        }

        //点击登录按钮
        private void btnLogon_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.combUserID.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录账号！", "登录提示");
                this.combUserID.Focus();
                return;
            }
            if (this.txtUserPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！", "登录提示");
                this.txtUserPwd.Focus();
                return;
            }
            //判断用户是否点击记住密码
            if (checkBoxRemberPwd.Checked == true)
            {
                txtRemberPwd.Text = "1";
                User objuser = new User()
                {
                    UserName = combUserID.Text.Trim(),
                    RemberPwd = Convert.ToInt32(txtRemberPwd.Text.Trim())
                };
                objUserService.UpdateRemberPwd(objuser);
            }
            //if (checkBoxRemberPwd.Checked == false)
            //{
            //    txtRemberPwd.Text = "0";
            //    User objuser = new User()
            //    {
            //        UserName = combUserID.Text.Trim(),
            //        RemberPwd = Convert.ToInt32(txtRemberPwd.Text.Trim())
            //    };
            //    objUserService.UpdateRemberPwd(objuser);
            //}
            ////判断用户是否自动登录
            //if (checkBoxAutomaticlogon.Checked == true)
            //{
            //    txtAutomaticlogon.Text = "1";
            //    User objuser = new User()
            //    {
            //        UserName = combUserID.Text.Trim(),
            //        Automaticlogon = Convert.ToInt32(txtAutomaticlogon.Text.Trim())
            //    };
            //    objUserService.UpdateAutomaticlogon(objuser);
            //}
            //if (checkBoxAutomaticlogon.Checked == false)
            //{
            //    txtAutomaticlogon.Text = "0";
            //    User objuser = new User()
            //    {
            //        UserName = combUserID.Text.Trim(),
            //        Automaticlogon = Convert.ToInt32(txtAutomaticlogon.Text.Trim())
            //    };
            //    objUserService.UpdateAutomaticlogon(objuser);
            //}
            //封装用户信息到用户对象
            User objUser = new User()
            {
                UserName = this.combUserID.Text.Trim(),
                UserPwd = Commons.EncodeHelper.AES_Encrypt(this.txtUserPwd.Text.Trim())
            };
            //提交用户信息
            try
            {
                objUser = objUserService.Userlogin(objUser);
                if (objUser == null)
                {
                    MessageBox.Show("用户名或密码错误！", "登录提示");
                }
                else
                {
                    Program.currentUser = objUser;//保存用户对象
                    this.DialogResult = DialogResult.OK;//设置登录成功信息提示
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录失败！");
            }
            

            //判断combUserName是否已经存在UserName
            if (this.objUserService.IsUserNameLogin(this.combUserID.Text.Trim()))
            {
                return;
            }
            else
            {
                //封装用户名到存储COMBBOX中
                UserExt objUserExt = new UserExt()
                {
                    UserName = this.combUserID.Text.Trim()
                };
                objUserService.AddUserLogin(objUserExt);
            }
           
        }

        //改进用户体验 回车键登录
        private void combUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.combUserID.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.txtUserPwd.Focus();
            }
        }
        private void txtUserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtUserPwd.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnLogon_Click(null, null);
            }
        }

        //用户点击忘记密码时显示忘记密码界面
        private void lblFindPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmFindPwd frm = new FrmFindPwd();
            frm.ShowDialog();
        }

        private void checkBoxRemberPwd_CheckedChanged(object sender, EventArgs e)
        {

            //txtUserPwd.Text = objUserService.GetUserPwd(combUserID.Text.Trim()).ToString();
        }

        private void FrmUserLogin_Shown(object sender, EventArgs e)
        {
            combUserID.Focus();
            combUserID.Text = ConfigurationManager.AppSettings["UserName"];
            if (ConfigurationManager.AppSettings["RemberPwd"].Equals("true"))
            {
                txtUserPwd.Text = ConfigurationManager.AppSettings["UserPwd"];
            }
        }
    }
}
