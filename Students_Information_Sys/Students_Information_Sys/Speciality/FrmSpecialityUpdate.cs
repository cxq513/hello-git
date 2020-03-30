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
    public partial class FrmSpecialityUpdate : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private CollageService objCollageService = new CollageService();
        private StudentService objStudentService = new StudentService();
        public FrmSpecialityUpdate()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }
        //专业浏览启动初始化


        //根据学院ID查询专业
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSpecialityRemakr.Text = null;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            this.combSpecialityName.SelectedIndex = -1;
            this.combSpecialityName.Text = null;
            //此顺序不可变更！
        }
        //根据专业下拉框查询专业信息
        private void combSpecialityName_TextChanged(object sender, EventArgs e)
        {
            if (combSpecialityName.Text != null)
            {
                this.txtSpecialityRemakr.Text = null;
                Speciality objSpeciality = objSpecialityService.GetSpecialityBySpecialityName(this.combSpecialityName.Text.Trim());
                this.txtSpecialityRemakr.Text = objSpeciality.Remark.ToString();
            }
            else
            {
                this.txtSpecialityRemakr.Text = null;
            }
        }

        //修改按钮
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //判断信息是否为空

            if (combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("不能修改专业名称！", "信息提示");
                this.combSpecialityName.Focus();
                return;
            }

            //封装学院信息
            Speciality objSpeciality = new Speciality()
            {
                SpecialityName = combSpecialityName.Text.Trim(),
                Remark = txtSpecialityRemakr.Text.Trim()
            };
            //提交对象
            //判断是否保存成功
            try
            {
                int result = objSpecialityService.UpdateSpeciality(objSpeciality);
                if (result == 1)
                {
                    MessageBox.Show("专业信息修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    this.combSpecialityName.Focus();

                }
                else
                {
                    MessageBox.Show("专业信息修改失败", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 优化用户体验，回车修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combSpecialityName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.combSpecialityName.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnUpdate_Click_1(null, null);
                this.combSpecialityName.Focus();
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
