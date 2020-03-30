using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 成绩信息
    /// </summary>
    public class Score
    {
        /// <summary>
        /// 成绩编号（自动编号）（主键）
        /// </summary>
        public int ScoreID { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// 学生学号
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        public int Score_ { get; set; }

        /// <summary>
        /// 课程编号
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 学生姓名加学号
        /// </summary>
        public string StudentNameAndNumber { get; set; }
    }
}
