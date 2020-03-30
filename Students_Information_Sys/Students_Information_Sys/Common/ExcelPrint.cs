using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Drawing;
using System.IO;
using Models.Ext;
using Models;
using DAL;
using Commons;

namespace Students_Information_Sys
{
    class ExcelPrint
    {
        public void  ExecutePrint (Student objStudent)
        {
            //定义一个Excle工作簿
            Microsoft.Office.Interop.Excel.Application excleApp = new Application();
            //获取已经创建好的工作簿
            string excleBookPath = Environment.CurrentDirectory + "\\StudentInfo.xls";
            //将现有的工作簿加入已定义的工作簿集合
            excleApp.Workbooks.Add(excleBookPath);
            //获取第一个工作表
            Worksheet objSheet = (Worksheet)excleApp.Worksheets[1];
            //在当前Excle中写入数据
            if (objStudent.StudentPhoto.Length != 0)
            {
                //将图片保存在指定的位置
                Image objImage = (Image)new
                    SerializeObjectToString().DeserializeObject(objStudent.StudentPhoto);
                if (File.Exists(Environment.CurrentDirectory + "\\Student.jpg"))
                {
                    File.Delete(Environment.CurrentDirectory + "\\Student.jpg");
                }
                else
                {
                    //保存图片到系统目录（当前会保存在DeBug或Release文件夹中）
                    objImage.Save(Environment.CurrentDirectory + "\\Student.jpg");
                    //将图片插入到Excle中
                    objSheet.Shapes.AddPicture(Environment.CurrentDirectory + "\\Student.jpg", MsoTriState.msoFalse, MsoTriState.msoTrue, 10, 50, 70, 80);
                    //使用完毕后删除保存的图片
                    File.Delete(Environment.CurrentDirectory + "\\Student.jpg");
                }
            }
            //写入其他相关数据
            objSheet.Cells[4,4] = objStudent.StudentNumber;//学号
            objSheet.Cells[6,4]= objStudent.StudentName;
            objSheet.Cells[8,4] = objStudent.StudentBrithday;
            objSheet.Cells[10,8] = objStudent.StudentNation;
            objSheet.Cells[10,4] = objStudent.IDnumber;
            objSheet.Cells[4,8] = objStudent.StudentSex;
            objSheet.Cells[6,8] = objStudent.StudentJob;
            objSheet.Cells[8,8] = objStudent.StudentPolitical;
            objSheet.Cells[12,8] = objStudent.StudentNativeplace;
            objSheet.Cells[14,8] = objStudent.StudentPhoneNumber;
            objSheet.Cells[12,2] = objStudent.StudentAddress;
            objSheet.Cells[14,2] = objStudent.StudentCollage;
            objSheet.Cells[16,2] = objStudent.SpecialityName;
            objSheet.Cells[16,8] = objStudent.ClassName;

            //打印预览
            excleApp.Visible = true;
            excleApp.Sheets.PrintPreview(true);

            //释放对象
            excleApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excleApp);
            excleApp = null;
        }
    }
}
