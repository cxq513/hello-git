using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 班级信息
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 班级编号（主键）
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        public string SpecialityName { get; set; }

        /// <summary>
        /// 专业ID
        /// </summary>
        public int SpecialtyID { get; set; }

        /// <summary>
        /// 教室编号
        /// </summary>
        public string ClassNum { get; set; }

        /// <summary>
        /// 学制
        /// </summary>
        public decimal SchoolReform { get; set; }

        /// <summary>
        /// 班主任
        /// </summary>
        public string HeadTeacher { get; set; }

        /// <summary>
        /// 入学时间
        /// </summary>
        public DateTime EnrolmentTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
