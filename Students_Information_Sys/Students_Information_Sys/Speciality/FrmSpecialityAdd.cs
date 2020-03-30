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
    public partial class FrmSpecialityAdd : DockContent
    {
        private CollageService objCollageService = new CollageService();
        SpecialityService objSpecialityService = new SpecialityService();
        public FrmSpecialityAdd()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetAllCollage();
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            combCollageName.SelectedIndex = -1;
        }

        //添加专业
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            if (txtSpecialityName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写专业名称！", "信息提示");
                this.txtSpecialityName.Focus();
                return;
            }
            if (combCollageName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写专业编号！", "信息提示");
                this.combCollageName.Focus();
                return;
            }
            //判断学院是否重复
            if (this.objSpecialityService.IsSpecialityNameExisted(this.txtSpecialityName.Text.Trim()))
            {
                MessageBox.Show("专业已经存在！", "验证提示");
                this.txtSpecialityName.Focus();
                this.txtSpecialityName.SelectAll();
                return;
            }
            //封装专业对象
            Speciality objSpeciality = new Speciality()
            {
                SpecialityName = txtSpecialityName.Text.Trim(),
                Remark = txtSpecialityRemakr.Text,
                CollageName = combCollageName.Text.Trim(),
                CollageID = Convert.ToInt32(this.combCollageName.SelectedValue)
            };

            //提交对象

            try
            {
                int result = objSpecialityService.AddSpeciality(objSpeciality);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("添加成功！是否继续添加", "添加询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //清空当前的文本框
                        foreach (Control item in this.tlpSpecialityAdd.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            else if (item is ComboBox)
                                ((ComboBox)item).SelectedIndex = -1;
                            else if (item is PictureBox)
                                ((PictureBox)item).Image = null;
                            else if (item is DateTimePicker)
                                ((DateTimePicker)item).Value = DateTime.Now;
                        }
                        txtSpecialityRemakr.Text = "";
                        combCollageName.SelectedIndex = -1;
                        txtSpecialityName.Text = "";
                        this.combCollageName.Focus();
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
        
