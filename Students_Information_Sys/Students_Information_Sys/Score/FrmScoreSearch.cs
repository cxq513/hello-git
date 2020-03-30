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
    public partial class FrmScoreSearch : DockContent
    {
        private ClassService objClassService = new ClassService();
        private SpecialityService objSpecialityService = new SpecialityService();
        public FrmScoreSearch()
        {
            InitializeComponent();
            //初始化班级下拉框
            this.combClassName.DataSource = objClassService.GetAllClass();
            this.combClassName.DisplayMember = "ClassName";
            this.combClassName.ValueMember = "ClassID";
            //初始化专业下拉框
            this.combSpecialityName.DataSource = objSpecialityService.GetAllSpeciality();
            this.combSpecialityName.DisplayMember = "SpecialityName";
            this.combSpecialityName.ValueMember = "SpecialityID";
        }
        //取消关闭当前窗口 
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
