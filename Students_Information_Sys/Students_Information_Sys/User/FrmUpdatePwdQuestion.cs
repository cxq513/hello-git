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
    public partial class FrmUpdatePwdQuestion : Form
    {
        private UserService objUserService = new UserService();//创建数据访问对象
        public FrmUpdatePwdQuestion()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //判断信息是否为空

            if (combNewPwdQuestion.SelectedIndex == -1)
            {
                MessageBox.Show("请选择密保问题！", "修改提示");
                this.combNewPwdQuestion.Focus();
                return;
            }

            if (txtNewPwdAnswer.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写密保答案！", "修改提示");
                this.txtNewPwdAnswer.Focus();
                return;
            }

            //封装密保信息
            User objUser = new User()
            {
                PwdQuestion = combNewPwdQuestion.Text.Trim(),
                PwdAnswer = txtNewPwdAnswer.Text.Trim(),
                UserName = Program.currentUser.UserName
            };
            //提交对象
            //判断是否保存成功
            try
            {
                int result = objUserService.UpdatePwdQuestion(objUser);
                if (result == 1)
                {
                    MessageBox.Show("密保修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("密保修改失败！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
