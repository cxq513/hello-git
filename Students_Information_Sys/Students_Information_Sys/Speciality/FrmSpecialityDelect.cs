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
    public partial class FrmSpecialityDelect : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private CollageService objCollageService = new CollageService();
        private StudentService objStudentService = new StudentService();
        public FrmSpecialityDelect()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }

        //根据学院ID查询专业
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSpecialityRemakr.Text = null;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            this.combSpecialityName.Text = "";
            //此顺序不可变更！
        }

        //根据专业下拉框查询专业信息
        private void combSpecialityName_TextChanged(object sender, EventArgs e)
        {
            if (combSpecialityName.Text == "")
            {
                this.txtSpecialityRemakr.Text = null;
            }
            else
            {
                this.txtSpecialityRemakr.Text = null;
                Speciality objSpeciality = objSpecialityService.GetSpecialityBySpecialityName(this.combSpecialityName.Text.Trim());
                this.txtSpecialityRemakr.Text = objSpeciality.Remark.ToString();
            }
        }
        
        //删除专业按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的专业名称
            string SpecialityName = this.combSpecialityName.Text.Trim();
            //根据学号删除
            try
            {
                if (objSpecialityService.DeleteSpeciality(SpecialityName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    //初始化学院下拉框
                    this.combCollageName.DisplayMember = "CollageName";
                    this.combCollageName.ValueMember = "CollageID";
                    this.combCollageName.DataSource = objCollageService.GetAllCollage();
                    this.combCollageName.Text = "";
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
