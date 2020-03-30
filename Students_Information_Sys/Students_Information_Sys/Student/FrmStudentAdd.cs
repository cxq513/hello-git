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
using Commons;
using System.IO;
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmStudentAdd : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();


        public FrmStudentAdd()
        {
            InitializeComponent();
            
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);

            combSpecialityName.DropDownStyle = ComboBoxStyle.DropDownList;
            combClassName.DropDownStyle = ComboBoxStyle.DropDownList;
            combStudentJob.DropDownStyle = ComboBoxStyle.DropDownList;
            combStudentPolitical.DropDownStyle = ComboBoxStyle.DropDownList;
            combStudentSex.DropDownStyle = ComboBoxStyle.DropDownList;
            combCollageName.DropDownStyle = ComboBoxStyle.DropDownList;

            //初始化相片框
            this.pictureBoxStudentPhoto.BackgroundImage = Image.FromFile("NoPicture.jpg");
            this.pictureBoxStudentPhoto.BackgroundImageLayout = ImageLayout.Zoom;
        }
        //根据学院ID查询专业
        private void combCollageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            combSpecialityName.DataSource = null;
            this.combSpecialityName.DataSource = objStudentService.GetSpecialityNameByCollageID(combCollageName.SelectedValue.ToString()).Tables[0].DefaultView;
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
            this.combSpecialityName.SelectedIndex = -1;
            this.combSpecialityName.SelectedIndexChanged += new System.EventHandler(this.combSpecialityName_SelectedIndexChanged);

        }
        //根据专业ID查询班级
        private void combSpecialityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combSpecialityName.DataSource != null)
            {
                combClassName.DataSource = null;
                this.combClassName.DataSource = objStudentService.GetClassNameBySpecialityID(combSpecialityName.SelectedValue.ToString()).Tables[0].DefaultView;
                this.combClassName.DisplayMember = "ClassName";
                this.combClassName.ValueMember = "ClassID";
                this.combClassName.SelectedIndex = -1;
            }
            else
            {
                combClassName.DataSource = null;
            }
        }

        //选择照片
        private void linkLabelPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            fileDialog.Title = "选择图片";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (result == DialogResult.OK)
            {

                this.pictureBoxStudentPhoto.Image = Image.FromFile(fileDialog.FileName);
            }
        }
        //添加学生
        private void btnadd_Click(object sender, EventArgs e)
        {
            #region 判断信息是否为空
            //判断信息是否为空
            if (txtStudentNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生姓名！", "信息提示");
                this.txtStudentNumber.Focus();
                return;
            }
            if (txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生姓名！", "信息提示");
                this.txtStudentName.Focus();
                return;
            }
            if (this.combStudentSex.SelectedIndex == -1)
            {
                MessageBox.Show("请选择性别！", "信息提示");
                this.combStudentSex.Focus();
                return;
            }
            if (txtIDnumber.Text.Length == 0)
            {
                MessageBox.Show("请输入身份证号！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIDnumber.Focus();
                return;
            }
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
            if (this.combClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "信息提示");
                this.combClassName.Focus();
                return;
            }
            if (this.combStudentJob.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学生职务！", "信息提示");
                this.combStudentJob.Focus();
                return;
            }
            if (this.combStudentPolitical.SelectedIndex == -1)
            {
                MessageBox.Show("请选择政治面貌！", "信息提示");
                this.combStudentPolitical.Focus();
                return;
            }
            if (txtStudentNation.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生民族！", "信息提示");
                this.txtStudentNation.Focus();
                return;
            }
            if (pictureBoxStudentPhoto.Image == null)
            {
                MessageBox.Show("请添加学生照片！", "信息提示");
                this.linkLabelPicture.Focus();
                return;
            }
            //验证身份证号是否符合要求
            if (!DateValidate.IsIDCard(this.txtIDnumber.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合格式要求！", "验证提示");
                this.txtIDnumber.Focus();
                this.txtIDnumber.SelectAll();
                return;
            }
            //验证身份证号是否和出生日期吻合
            string month = string.Empty;
            string day = string.Empty;
            if (Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Month < 10)
                month = "0" + Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Month;
            else
                month = Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Month.ToString();
            if (Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Day < 10)
                day = "0" + Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Day;
            else
                day = Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Day.ToString();
            string birthday = Convert.ToDateTime(this.dateTimeStudentBrithday.Text).Year.ToString() + month + day;

            if (!this.txtIDnumber.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证号和出生日期不匹配！", "验证提示");
                this.txtIDnumber.Focus();
                this.txtIDnumber.SelectAll();
                return;
            }
            //判断身份证号是否重复
            if (this.objStudentService.IsIDNumberExisted(this.txtIDnumber.Text.Trim()))
            {
                MessageBox.Show("身份证号已经存在！", "验证提示");
                this.txtIDnumber.Focus();
                this.txtIDnumber.SelectAll();
                return;
            }
            //判断学号是否重复
            if (this.objStudentService.IsStudentNumberExisted(this.txtStudentNumber.Text.Trim()))
            {
                MessageBox.Show("学号已经存在！", "验证提示");
                this.txtStudentNumber.Focus();
                this.txtStudentNumber.SelectAll();
                return;
            }
            #endregion

            //封装学生对象
            Student objStudent = new Student()
            {
                StudentNumber = txtStudentNumber.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                StudentSex = combStudentSex.Text.Trim(),
                ClassName = combClassName.Text.Trim(),
                ClassID = Convert.ToInt32(combClassName.SelectedValue),
                StudentBrithday = dateTimeStudentBrithday.Value,
                StudentNativeplace = txtStudentNativeplace.Text.Trim(),
                StudentPhoneNumber = txtStudentPhoneNumber.Text.Trim(),
                StudentNation = txtStudentNation.Text.Trim(),
                StudentPolitical = combStudentPolitical.Text.Trim(),
                SpecialityName = combSpecialityName.Text.Trim(),
                IDnumber = txtIDnumber.Text.Trim(),
                //StudentPwd = Commons.EncodeHelper.AES_Encrypt(objStudent.IDnumber.Substring(12, 6)),
                StudentCollage = combCollageName.Text.Trim(),
                StudentAddress = txtStudentAddress.Text.Trim(),
                StudentJob = combStudentJob.Text.Trim(),
                StudentPhoto = this.pictureBoxStudentPhoto.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pictureBoxStudentPhoto.Image)
            };

            //提交对象
            //判断是否保存成功

            try
            {
                int result = objStudentService.AddStudent(objStudent);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("添加成功！是否继续添加", "添加询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //清空当前的文本框
                        foreach (Control item in this.tlpStudentAdd.Controls)
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
                        this.txtStudentNumber.Focus();
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
