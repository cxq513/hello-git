using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Ext
{
    public class StudentExt:Student
    {
        public new string ClassName { get; set; }
        public DateTime DTime { get; set; }//签到时间
    }
}
