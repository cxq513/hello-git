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
    public partial class FrmAnswerPwdQuestion : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象
        public FrmAnswerPwdQuestion()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //判断是否存在用户名以及密保问题和答案是否一致
            if (this.objUserService.IsUserExisted(Program.currentUser.UserName, this.combPwdQuestion.Text.Trim(), txtPwdAnswer.Text.Trim()))
            {
                MessageBox.Show("密保问题不正确或密保答案不正确！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.combPwdQuestion.Focus();
                this.combPwdQuestion.SelectAll();
                return;
            }
            else
            {
                FrmUpdatePwdQuestion objUpdatePwdQuestion = new FrmUpdatePwdQuestion();
                DialogResult result = objUpdatePwdQuestion.ShowDialog();

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
