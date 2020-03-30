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
    public partial class FrmCollageDelete : DockContent
    {
        private CollageService objCollageService = new CollageService();
        public FrmCollageDelete()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.DataSource = objCollageService.GetAllCollage();
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }

        //通过学院名下拉框显示学院信息
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCollageName.Text == "")
            {
                txtCollageDescribe.Text = null;
            }
            else
            {
                Collage objCollage = objCollageService.GetCollageByCollageName(this.combCollageName.Text.Trim());
                this.txtCollageDescribe.Text = objCollage.Remark.ToString();
            }
        }

        //删除按钮
        private void btnDelect_Click(object sender, EventArgs e)
        {
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string CollageName = this.combCollageName.Text.Trim();
            //根据学号删除
            try
            {
                if (objCollageService.DeleteCollage(CollageName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    this.combCollageName.DisplayMember = "CollageName";
                    this.combCollageName.ValueMember = "CollageID";
                    this.combCollageName.DataSource = objCollageService.GetAllCollage();
                    this.combCollageName.SelectedIndex = -1;
                    this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "删除信息");
            }
        }
        //取消关闭当前窗口
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
