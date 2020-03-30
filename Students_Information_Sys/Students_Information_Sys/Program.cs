using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace Students_Information_Sys
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //显示登录窗体
            FrmUserLogin objLoginFrom = new FrmUserLogin();
            DialogResult result = objLoginFrom.ShowDialog();

            //判断是否登陆成功
            if (result == DialogResult.OK)
                Application.Run(new FrmMain());
            else
                Application.Exit();//退出整个程序
        }

        //定义一个全局变量
        public static User currentUser = null;
    }
}
