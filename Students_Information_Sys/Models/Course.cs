using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 课程信息
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程编号（自动编号）（主键）
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// 班级编号
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// 任课教师
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// 教师联系方式
        /// </summary>
        public string TeacherPhoneNumber { get; set; }
    }
}
