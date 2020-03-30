using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        /// <summary>
        /// 用户编号（自动编号）
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 用户名称（主键）
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public string fileRoleName { get; set; }

        /// <summary>
        /// 密保问题
        /// </summary>
        public string PwdQuestion { get; set; }

        /// <summary>
        /// 密保答案
        /// </summary>
        public string PwdAnswer { get; set; }

        /// <summary>
        /// 注册口令
        /// </summary>
        public string RegistrationPwd { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 记住密码
        /// </summary>
        public int RemberPwd { get; set; }

        /// <summary>
        /// 自动登录
        /// </summary>
        public int Automaticlogon { get; set; }

    }
}
