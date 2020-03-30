using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 学生信息
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学生编号（自动编号）
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// 学号（主键）
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string StudentSex { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime StudentBrithday { get; set; }

        /// <summary>
        /// 籍贯
        /// </summary>
        public string StudentNativeplace { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string StudentPhoneNumber { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string StudentNation { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        public string StudentPolitical { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public string SpecialityName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDnumber { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string StudentPwd { get; set; }

        /// <summary>
        /// 学院
        /// </summary>
        public string StudentCollage { get; set; }

        /// <summary>
        /// 家庭地址
        /// </summary>
        public string StudentAddress { get; set; }

        /// <summary>
        /// 学生职务
        /// </summary>
        public string StudentJob { get; set; }

        /// <summary>
        /// 学生照片
        /// </summary>
        public string StudentPhoto { get; set; }
    }
}
