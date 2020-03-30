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
    public partial class FrmCollageBrowse : DockContent
    {
        private CollageService objCollageService = new CollageService();
        //定义学院信息集合 
        List<Collage> list = null;

        public FrmCollageBrowse()
        {
            InitializeComponent();
        }


        //修改学院按钮
        private void btnSpecialityUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvCollage.RowCount == 0 || this.dgvCollage.CurrentRow == null)
            {
                MessageBox.Show("没有要修改的信息！", "修改提示");
                return;
            }
            //获取要修改学生的学号
            string CollageName = this.dgvCollage.CurrentRow.Cells["CollageName"].Value.ToString();
            Collage objCollage = objCollageService.GetCollageByCollageName(CollageName);
            //显示修改窗体
            FrmCollageUpdate objUpdateForm = new FrmCollageUpdate(objCollage);
            DialogResult result = objUpdateForm.ShowDialog();
            //判断是否修改成功
            if (result == DialogResult.OK)
            {
                list = objCollageService.GetCollageBagByCollageName();
                this.dgvCollage.AutoGenerateColumns = false;
                this.dgvCollage.DataSource = list;
            }
        }

        private void FrmCollageBrowse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“students_Information_SysDataSet1.tbCollageInfo”中。您可以根据需要移动或删除它。
            this.tbCollageInfoTableAdapter.Fill(this.students_Information_SysDataSet1.tbCollageInfo);

        }


        //删除学院信息按钮
        private void btnCollageDelect_Click(object sender, EventArgs e)
        {
            //判断信息
            if (dgvCollage.RowCount == 0)
            {
                MessageBox.Show("没有要删除的对象", "删除提示");
                return;
            }
            if (dgvCollage.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的对象", "删除提示");
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string CollageName = dgvCollage.CurrentRow.Cells["CollageName"].Value.ToString();
            //根据学号删除
            try
            {
                if (objCollageService.DeleteCollage(CollageName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    list = objCollageService.GetCollageBagByCollageName();
                    this.dgvCollage.AutoGenerateColumns = false;
                    this.dgvCollage.DataSource = list;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "删除信息");
            }
        }
        //取消关闭当前窗口
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
