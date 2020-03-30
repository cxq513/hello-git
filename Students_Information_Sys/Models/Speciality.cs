using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 专业信息
    /// </summary>
    public class Speciality
    {
        /// <summary>
        /// 专业编号（自动编号）（主键）
        /// </summary>
        public int SpecialityID { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        public string SpecialityName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string CollageName { get; set; }

        /// <summary>
        /// 学院ID
        /// </summary>
        public int CollageID { get; set; }
    }
}
