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
using DAL;
using Models;

namespace Students_Information_Sys
{
    public partial class FrmStudentUpdate : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private CollageService objCollageService = new CollageService();
        private StudentService objStudentService = new StudentService();
        public FrmStudentUpdate()
        {
            InitializeComponent();

            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
        }
        public FrmStudentUpdate(Student objStudent)
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);
            this.txtStudentNumber.Text = objStudent.StudentNumber.ToString();
            this.txtStudentName.Text = objStudent.StudentName;
            combStudentSex.Text = objStudent.StudentSex;
            dateTimeStudentBrithday.Text = objStudent.StudentBrithday.ToString();
            txtIDnumber.Text = objStudent.IDnumber;
            txtStudentAddress.Text = objStudent.StudentPhoneNumber;
            txtStudentNation.Text = objStudent.StudentNation;
            txtStudentNativeplace.Text = objStudent.StudentNativeplace;
            txtStudentAddress.Text = objStudent.StudentAddress;
            combStudentPolitical.Text = objStudent.StudentPolitical;
            combCollageName.Text = objStudent.StudentCollage;
            combStudentJob.Text = objStudent.StudentJob;
            txtStudentPhoneNumber.Text = objStudent.StudentPhoneNumber;
            combSpecialityName.Text = objStudent.SpecialityName;
            combClassName.Text = objStudent.ClassName;
            pictureBoxStudentPhoto.Image = objStudent.StudentPhoneNumber.Length == 0 ? Image.FromFile("NoPicture.jpg") :
                (Image)new SerializeObjectToString().DeserializeObject(objStudent.StudentPhoto);
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
            if (result == DialogResult.OK)
            {
                this.pictureBoxStudentPhoto.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        /// <summary>
        /// 查找学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtStudentNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入要查询的学号！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtStudentNumber.Focus();
                return;
            }
            //根据学号查询学学生对象
            Student objStudent = objStudentService.GetStudent(this.txtStudentNumber.Text.Trim());
            if (objStudent == null)
            {
                MessageBox.Show("您输入的学号不正确，未找到该学生信息", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtStudentNumber.Focus();
                this.txtStudentNumber.SelectAll();
                return;
            }
            else
            {
                this.txtStudentNumber.Text = objStudent.StudentNumber.ToString();
                this.txtStudentName.Text = objStudent.StudentName;
                combStudentSex.Text = objStudent.StudentSex;
                dateTimeStudentBrithday.Text = objStudent.StudentBrithday.ToString();
                txtIDnumber.Text = objStudent.IDnumber;
                txtStudentAddress.Text = objStudent.StudentPhoneNumber;
                txtStudentNation.Text = objStudent.StudentNation;
                txtStudentNativeplace.Text = objStudent.StudentNativeplace;
                txtStudentAddress.Text = objStudent.StudentAddress;
                combStudentPolitical.Text = objStudent.StudentPolitical;
                combCollageName.Text = objStudent.StudentCollage;
                combStudentJob.Text = objStudent.StudentJob;
                txtStudentPhoneNumber.Text = objStudent.StudentPhoneNumber;
                combSpecialityName.Text = objStudent.SpecialityName;
                combClassName.Text = objStudent.ClassName;
                pictureBoxStudentPhoto.Image = objStudent.StudentPhoneNumber.Length == 0 ? Image.FromFile("NoPicture.jpg") :
                    (Image)new SerializeObjectToString().DeserializeObject(objStudent.StudentPhoto);
            }
        }






        /// <summary>
        /// 修改学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            #region 判断信息是否为空
            //判断信息是否为空
            if (txtStudentNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生姓名！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtStudentNumber.Focus();
                return;
            }
            if (txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生姓名！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtStudentName.Focus();
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
                MessageBox.Show("请选择学院！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.combCollageName.Focus();
                return;
            }
            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择专业！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.combSpecialityName.Focus();
                return;
            }
            if (this.combClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.combClassName.Focus();
                return;
            }
            if (txtStudentNation.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写学生民族！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtStudentNation.Focus();
                return;
            }
            if (pictureBoxStudentPhoto.Image == null)
            {
                MessageBox.Show("请添加学生照片！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.linkLabelPicture.Focus();
                return;
            }
            //验证身份证号是否符合要求
            if (!DateValidate.IsIDCard(this.txtIDnumber.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合格式要求！", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("身份证号和出生日期不匹配！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIDnumber.Focus();
                this.txtIDnumber.SelectAll();
                return;
            }
            ////判断身份证号是否重复
            if (this.objStudentService.IsIDNumberNoExisted(this.txtIDnumber.Text.Trim(), this.txtStudentNumber.Text.Trim()))
            {
                MessageBox.Show("身份证号不能和现有学生身份证号重复！", "修改提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtIDnumber.Focus();
                this.txtIDnumber.SelectAll();
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
                int result = objStudentService.UpdateStudent(objStudent);
                if (result == 1)
                {
                    MessageBox.Show("学生信息修改成功！", "修改提示");
                    this.DialogResult = DialogResult.OK;
                    this.txtStudentNumber.Focus();
                }
                else
                {
                    MessageBox.Show("学生信息修改失败,不可以更改学生学号！", "添加提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStudentNumber.Text.Trim().Length == 0) return;
            if (e.KeyValue == 13)
            {
                this.button1_Click(null, null);
                this.txtStudentNumber.Focus();
            }
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
        //取消关闭当前窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
