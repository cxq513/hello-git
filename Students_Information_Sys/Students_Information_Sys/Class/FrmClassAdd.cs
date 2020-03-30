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
    public partial class FrmClassAdd : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        public FrmClassAdd()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);

        }
        //根据学院ID查询专业
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            combSpecialityName.DataSource = null;
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.SelectedIndex = -1;
        }

        //添加班级
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断信息是否为空
            if (this.combCollageName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学院！", "信息提示");
                this.combCollageName.Focus();
                return;
            }

            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择专业！", "信息提示");
                this.combSpecialityName.Focus();
                return;
            }

            if (txtClassName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写班级名称！", "信息提示");
                this.txtClassName.Focus();
                return;
            }
            
            if (txtHeadTeacher.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写班主任！", "信息提示");
                this.txtHeadTeacher.Focus();
                return;
            }
            if (this.numericUpDownSchoolReform.Value == 0)
            {
                MessageBox.Show("请选择学制！", "信息提示");
                this.txtHeadTeacher.Focus();
                return;
            }

            //判断班级是否重复
            if (this.objClassService.IsClassNameExisted(this.txtClassName.Text.Trim()))
            {
                    MessageBox.Show("班级已经存在！", "验证提示");
                    this.txtClassName.Focus();
                    this.txtClassName.SelectAll();
                    return;
            }

            //封装学院对象
            Class objClass = new Class()
            {
                ClassName = txtClassName.Text.Trim(),
                SpecialityName = combSpecialityName.Text.Trim(),
                ClassNum = txtClassNum.Text.Trim(),
                SchoolReform = numericUpDownSchoolReform.Value,
                HeadTeacher = txtHeadTeacher.Text.Trim(),
                EnrolmentTime = dateTimeEnrolmentTime.Value,
                Remark = txtRemark.Text,
                SpecialtyID = Convert.ToInt32(this.combSpecialityName.SelectedValue)
            };

            //提交对象

            try
            {
                int result = objClassService.AddClass(objClass);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("添加成功！是否继续添加", "添加询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //清空当前的文本框
                        foreach (Control item in this.tblpClassAdd.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            else if (item is ComboBox)
                                ((ComboBox)item).SelectedIndex = -1;
                            else if (item is PictureBox)
                                ((PictureBox)item).Image = null;
                            else if (item is DateTimePicker)
                                ((DateTimePicker)item).Value = DateTime.Now;
                            else if(item is NumericUpDown)
                                ((NumericUpDown)item).Value = 0;
                        }
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

        //回车键
        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtRemark.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.btnAdd_Click(null, null);
                this.combCollageName.Focus();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        //取消关闭当前窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
