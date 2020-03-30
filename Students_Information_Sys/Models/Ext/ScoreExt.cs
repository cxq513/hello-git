using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ScoreExt :Score
    {
        /// <summary>
        /// 成绩编号（自动编号）（主键）
        /// </summary>
        public new int ScoreID { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public new string Semester { get; set; }

        /// <summary>
        /// 学生学号
        /// </summary>
        public new string StudentNumber { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public new string CourseName { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        public new int Score_ { get; set; }

        /// <summary>
        /// 课程编号
        /// </summary>
        public new int CourseID { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        public new string ClassName { get; set; }

        /// <summary>
        /// 学生姓名加学号
        /// </summary>
        public new string StudentNameAndNumber { get; set; }
    }
}
