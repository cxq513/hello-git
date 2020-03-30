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
    public partial class FrmSpecialityBrowse : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private SpecialityService objSpecialityService = new SpecialityService();
        //定义专业信息集合 
        List<Speciality> list = null;

        public FrmSpecialityBrowse()
        {
            InitializeComponent();
        }

        private void FrmSpecialityBrowse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“students_Information_SysDataSet3.tbSpecialityInfo”中。您可以根据需要移动或删除它。
            this.tbSpecialityInfoTableAdapter.Fill(this.students_Information_SysDataSet3.tbSpecialityInfo);


        }
        //修改专业按钮
        private void btnSpecialityUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvSpeciality.RowCount == 0 || this.dgvSpeciality.CurrentRow == null)
            {
                MessageBox.Show("没有要修改的信息！", "修改提示");
                return;
            }
            //获取要修改专业的名称
            string SpecialityName = this.dgvSpeciality.CurrentRow.Cells["SpecialityName"].Value.ToString();
            Speciality objSpeciality = objSpecialityService.GetSpecialityBySpecialityName(SpecialityName);
            //显示修改窗体
            FrmSpecialityUpdateByBrowse objUpdateForm = new FrmSpecialityUpdateByBrowse(objSpeciality);
            DialogResult result = objUpdateForm.ShowDialog();
            //判断是否修改成功
            if (result == DialogResult.OK)
            {
                list = objSpecialityService.GetSpecialityBag();
                this.dgvSpeciality.AutoGenerateColumns = false;
                this.dgvSpeciality.DataSource = list;
            }
        }

        private void btnSpecialityDelect_Click(object sender, EventArgs e)
        {
            //判断信息
            if (dgvSpeciality.RowCount == 0)
            {
                MessageBox.Show("没有要删除的对象", "删除提示");
                return;
            }
            if (dgvSpeciality.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的对象", "删除提示");
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string SpecialityName = dgvSpeciality.CurrentRow.Cells["SpecialityName"].Value.ToString();
            //根据学号删除
            try
            {
                if (objSpecialityService.DeleteSpeciality(SpecialityName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    list = objSpecialityService.GetSpecialityBag();
                    this.dgvSpeciality.AutoGenerateColumns = false;
                    this.dgvSpeciality.DataSource = list;
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
