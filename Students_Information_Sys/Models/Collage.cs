using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 学院信息
    /// </summary>

    public class Collage
    {
        /// <summary>
        /// 学院编号（自动编号）（主键）
        /// </summary>
        public int CollageID { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string CollageName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}

