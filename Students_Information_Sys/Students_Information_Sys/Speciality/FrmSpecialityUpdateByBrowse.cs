using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmSpecialityUpdateByBrowse : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private CollageService objCollageService = new CollageService();
        private StudentService objStudentService = new StudentService();
        public FrmSpecialityUpdateByBrowse()
        {
            InitializeComponent();
        }
        //专业浏览启动初始化
        public FrmSpecialityUpdateByBrowse(Speciality objSpeciality)
        {
            InitializeComponent();
            this.txtCollageName.Text = objSpeciality.CollageName.ToString();
            this.txtSpecialityName.Text = objSpeciality.SpecialityName.ToString();
            this.txtSpecialityRemakr.Text = objSpeciality.Remark.ToString();
        }

        //修改按钮
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //封装专业信息
            Speciality objSpeciality = new Speciality()
            {
                CollageName = txtCollageName.Text.Trim(),
                SpecialityName = txtSpecialityName.Text.Trim(),
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
                    this.txtSpecialityRemakr.Focus();

                }
                else
                {
                    MessageBox.Show("专业信息修改失败", "添加提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
