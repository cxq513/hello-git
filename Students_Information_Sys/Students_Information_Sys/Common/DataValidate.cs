using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Students_Information_Sys
{


    /// <summary>
    /// 通用验证类
    /// </summary>
    public class DateValidate
    {
        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsInteger(string txt)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(txt);
        }

        /// <summary>
        /// 验证是否是Emile
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsEmile(string txt)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)");
            return objReg.IsMatch(txt);
        }

        public static bool IsIDCard(string txt)
        {
            Regex objReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return objReg.IsMatch(txt);
        }
    }
}


