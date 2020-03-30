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
    public partial class FrmRegistrationPwd : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象

        public FrmRegistrationPwd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtRegistrationPwd.Text.Length == 0)
            {
                MessageBox.Show("请输入注册口令！", "注册提示");
                this.txtRegistrationPwd.Focus();
                this.txtRegistrationPwd.SelectAll();
                return;
            }
            if (this.objUserService.IsRegistrationPwd(txtRegistrationPwd.Text.Trim()))
            {
                //删除注册口令
                string RegistrationPwd = txtRegistrationPwd.Text.Trim();
                objUserService.DeleteRegistrationPwd(RegistrationPwd);

                //关闭注册口令界面
                this.Close();

                //打开注册界面
                FrmRegister frm = new FrmRegister();
                frm.ShowDialog();

                
            }
            else
            {
                MessageBox.Show("注册口令不存在或已失效！", "注册提示");
                this.txtRegistrationPwd.Focus();
                this.txtRegistrationPwd.SelectAll();
                return;
            }
        }
    }
}
