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
    public partial class FrmClassBrowse : DockContent
    {
        private CollageService objCollageService = new CollageService();
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        private StudentService objStudentService = new StudentService();
        public FrmClassBrowse()
        {
            InitializeComponent();
            //初始化学院下拉框
            this.combCollageName.DataSource = objCollageService.GetCollage().Tables[0].DefaultView;
            this.combCollageName.DisplayMember = "CollageName";
            this.combCollageName.ValueMember = "CollageID";
            this.combCollageName.SelectedIndex = -1;
            this.combCollageName.SelectedIndexChanged += new System.EventHandler(this.combCollageName_SelectedIndexChanged);


            this.dateTimeEnrolmentTime.Value = DateTime.Today;
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

        //定义学生信息集合 
        List<Class> list = null;
        //按照班级查询
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个专业", "信息提示");
                this.combSpecialityName.Focus();
                return;
            }
            list = objClassService.GetSpecialityID(this.combSpecialityName.SelectedValue.ToString());
            this.dgvGetClass.AutoGenerateColumns = false;
            this.dgvGetClass.DataSource = list;
        }
        //修改班级信息
        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvGetClass.RowCount == 0 || this.dgvGetClass.CurrentRow == null)
            {
                MessageBox.Show("没有要修改的信息！", "打印提示");
                return;
            }
            //获取要修改学生的学号
            string ClassName = this.dgvGetClass.CurrentRow.Cells["ClassName"].Value.ToString();
            Class objClass = objClassService.GetClass(ClassName);
            //显示修改窗体
            FrmClassUpdateByBrowse objUpdateForm = new FrmClassUpdateByBrowse(objClass);
            DialogResult result = objUpdateForm.ShowDialog();
            //判断是否修改成功
            if (result == DialogResult.OK)
            {
                btnSearch_Click_1(null, null);
            }
        }

        private void btnClassDelect_Click(object sender, EventArgs e)
        {
            //判断信息
            if (dgvGetClass.RowCount == 0)
            {
                MessageBox.Show("没有要删除的对象", "删除提示");
                return;
            }
            if (dgvGetClass.CurrentRow == null)
            {
                MessageBox.Show("请选择要删除的对象", "删除提示");
                return;
            }
            //删除确认
            DialogResult result = MessageBox.Show("确认要删除吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取要删除的学号
            string ClassName = dgvGetClass.CurrentRow.Cells["ClassName"].Value.ToString();
            //根据学号删除
            try
            {
                if (objClassService.DeleteClass(ClassName) == 1)
                {
                    MessageBox.Show("删除成功！", "删除提示");
                    //list = objClassService.GetClassesBagByClassName();
                    //this.dgvGetClass.AutoGenerateColumns = false;
                    //this.dgvGetClass.DataSource = list;
                    btnSearch_Click_1(null, null);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "删除信息");
            }
        }

        private void btnSearchByTime_Click(object sender, EventArgs e)
        {
            if (this.combSpecialityName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个专业", "信息提示");
                this.combSpecialityName.Focus();
                return;
            }
            if (this.dateTimeEnrolmentTime.Value == DateTime.Now)
            {
                MessageBox.Show("请选择入学时间", "信息提示");
                this.combSpecialityName.Focus();
                return;
            }
            //根据学号查询学学生对象
            Class objClass = objClassService.GetClassBySpecialityNameAndEnrolmentTime(combSpecialityName.Text,dateTimeEnrolmentTime.Value.ToString());
            if (objClass == null)
            {
                MessageBox.Show("您输入的专业或入学时间不正确，未找到该班级信息", "信息提示");
                this.dateTimeEnrolmentTime.Focus();
                return;
            }
            else
            {
                list = objClassService.GetClassListBySpecialityNameAndEnrolmentTime(this.combSpecialityName.Text, this.dateTimeEnrolmentTime.Value.ToString());
                this.dgvGetClass.AutoGenerateColumns = false;
                this.dgvGetClass.DataSource = list;
            }

        }
        //取消关闭当前窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
