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
    public partial class FrmCollageAdd : DockContent
    {
        private CollageService objCollageService = new CollageService();
        public FrmCollageAdd()
        {
            InitializeComponent();
        }

        //添加学院
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            
            if (txtCollageName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学院名称！", "信息提示");
                this.txtCollageName.Focus();
                return;
            }

            //判断学院是否重复
            if (this.objCollageService.IsCollageNameExisted(this.txtCollageName.Text.Trim()))
            {
                MessageBox.Show("学院已经存在！", "验证提示");
                this.txtCollageName.Focus();
                this.txtCollageName.SelectAll();
                return;
            }
            //封装学院对象
            Collage objCollage = new Collage()
            {
                CollageName = txtCollageName.Text.Trim(),
                Remark = txtCollageRemakr.Text
            };

            //提交对象

            try
            {
                int result = objCollageService.AddCollage(objCollage);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("添加成功！是否继续添加", "添加询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //清空当前的文本框
                        txtCollageName.Text = "";
                        txtCollageRemakr.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("添加失败！", "添加提示");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //取消关闭当前窗口 
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
