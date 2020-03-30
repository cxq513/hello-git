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
    public partial class FrmCollageUpdate : DockContent
    {
        private CollageService objCollageService = new CollageService();
        public FrmCollageUpdate()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetAllCollage();
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }
        public FrmCollageUpdate(Collage objCollage)
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetAllCollage();
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
            this.combCollageName.Text = objCollage.CollageName.ToString();
            this.txtCollageRemakr.Text = objCollage.Remark.ToString();
        }
        //通过学院名下拉框显示学院信息
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Collage objCollage = objCollageService.GetCollageByCollageName(this.combCollageName.Text.Trim());
            this.txtCollageRemakr.Text = objCollage.Remark.ToString();
        }
        //提交修改按钮
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            
            if (combCollageName.SelectedIndex == -1)
            {
                MessageBox.Show("不能修改学院名称！", "信息提示");
                this.combCollageName.Focus();
                return;
            }

            //封装学院信息
            Collage objCollage = new Collage()
            {
                CollageName = combCollageName.Text.Trim(),
                Remark = txtCollageRemakr.Text.Trim()
            };
            //提交对象
            //判断是否保存成功
            try
            {
                int result = objCollageService.UpdateCollage(objCollage);
                if (result == 1)
                {
                    MessageBox.Show("学院信息修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    this.combCollageName.Focus();
                    
                }
                else
                {
                    MessageBox.Show("学院信息修改失败", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 优化用户体验，回车修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCollageName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.combCollageName.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnUpdate_Click(null, null);
                this.combCollageName.Focus();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        //取消关闭当前窗口
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
