using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Models;
using DAL;

namespace DAL
{
    /// <summary>
    /// 用户数据访问类
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// 根据用户名或密码登录
        /// </summary>
        /// <param name="objUser">被实例化的User类</param>
        /// <returns></returns>
        public User Userlogin(User objUser)
        {
            string sql = "SELECT UserName FROM tbUserInfo WHERE UserName='{0}' and UserPwd ='{1}'";
            sql = string.Format(sql, objUser.UserName, objUser.UserPwd);
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objUser.UserName = objReader["UserName"].ToString();
                }

                else
                {
                    objUser = null;
                }
                objReader.Close();
                return objUser;
            }
            catch (Exception ex)
            {
                throw new Exception("数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="NewPwd"></param>
        /// <returns></returns>
        public int PwdUpdate(string UserName, string NewPwd)
        {
            string sql = "UPDATE tbUserInfo SET UserPwd = '{0}' WHERE UserName = '{1}'";
            sql = string.Format(sql, NewPwd, UserName);
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 判断用户名是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool IsUserNameExisted(string UserName)
        {
            string sql = "SELECT COUNT(*) FROM tbUserInfo WHERE UserName = '" + UserName + "'";
            sql = string.Format(sql, UserName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 添加（注册）用户
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public int AddUser(User objUser)
        {
            User user = new User();
            string sql = @"INSERT INTO [dbo].[tbUserInfo]
                                       ([UserName]
                                       ,[UserPwd]
                                       ,[fileRoleName]
                                       ,[PwdQuestion]
                                       ,[RegisterTime]
                                       ,[PwdAnswer])
                                 VALUES
                                       ('" + objUser.UserName + @"'
                                       ,'" + objUser.UserPwd + @"'
                                       ,'" + objUser.fileRoleName + @"'
                                       ,'" + objUser.PwdQuestion + @"'
                                       ,'" + objUser.RegisterTime + @"'
                                       ,'" + objUser.PwdAnswer + @"')";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {

                throw new Exception("添加用户出现问题！" + ex.Message);
            }
        }

        /// <summary>
        /// 判断是否存在用户以及密保问题和答案是否正确
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="PwdQuestion"></param>
        /// <param name="PwdAnswer"></param>
        /// <returns></returns>
        public bool IsUserExisted(string UserName, string PwdQuestion, string PwdAnswer)
        {
            string sql = "SELECT COUNT(*) FROM tbUserInfo WHERE UserName = '" + UserName + "'" +
                "AND PwdQuestion ='" + PwdQuestion + "'AND PwdAnswer ='" + PwdAnswer + "'";
            sql = string.Format(sql, UserName, PwdQuestion, PwdAnswer);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return false;
            else return true;
        }

        /// <summary>
        /// 存储用户名到combUserName中
        /// </summary>
        /// <param name="objUserExt"></param>
        /// <returns></returns>
        public int AddUserLogin(UserExt objUserExt)
        {
            UserExt user = new UserExt();
            string sql = @"INSERT INTO [dbo].[tbUserLoginInfo]
                                       ([UserName])
                                 VALUES
                                       ('" + objUserExt.UserName + @"')";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 动态获取UserName放入combUserName中
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserName()
        {
            string sql = "SELECT  UserName FROM tbUserLoginInfo";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 查询UserName是否已近存入combUserName中
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public bool IsUserNameLogin(string UserName)
        {
            string sql = "SELECT COUNT(*) FROM tbUserLoginInfo WHERE UserName ='{0}'";
            sql = string.Format(sql, UserName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 验证是否存在注册口令
        /// </summary>
        /// <param name="RegistrationPwd"></param>
        /// <returns></returns>
        public bool IsRegistrationPwd(string RegistrationPwd)
        {
            string sql = "SELECT COUNT(*) FROM tbRegistrationPwdInfo WHERE RegistrationPwd = '" + RegistrationPwd + "'";
            sql = string.Format(sql, RegistrationPwd);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 删除注册口令
        /// </summary>
        /// <param name="RegistrationPwd"></param>
        /// <returns></returns>
        public int DeleteRegistrationPwd(string RegistrationPwd)
        {
            string sql = "DELETE FROM tbRegistrationPwdInfo WHERE RegistrationPwd ='" + RegistrationPwd + "'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 更新用户登录时间
        /// </summary>
        /// <param name="objUserExt"></param>
        /// <returns></returns>
        public int UpdateLoginTime(UserExt objUserExt)
        {
            string sql = "UPDATE [dbo].[tbUserLoginInfo]SET" +
                                      "[LoginTime] ='" + objUserExt.LoginTime + @"'
                                  WHERE UserName = '" + objUserExt.UserName + @"'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 查询登录时间
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public UserExt SelectUserLoginTime(string UserName)
        {
            string sql = "SELECT LoginTime FROM tbUserLoginInfo WHERE UserName = '" + UserName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            UserExt objUserExt = null;
            if (objReader.Read())
            {
                objUserExt = new UserExt()
                {
                    LoginTime = Convert.ToDateTime(objReader["LoginTime"]),
                };
            }
            objReader.Close();
            return objUserExt;
        }

        /// <summary>
        /// 查找注册时间
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public User SelectUserRegisterTime(string UserName)
        {
            string sql = "SELECT RegisterTime FROM tbUserInfo WHERE UserName = '" + UserName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            User objUser = null;
            if (objReader.Read())
            {
                objUser = new User()
                {
                    RegisterTime = Convert.ToDateTime(objReader["RegisterTime"]),
                };
            }
            objReader.Close();
            return objUser;
        }

        /// <summary>
        /// 注销用户删除用户名等信息
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public int DeleteUser(string UserName)
        {
            string sql = "DELETE FROM tbUserInfo WHERE UserName ='" + UserName + "'";
            return SQLHelper.Update(sql);
        }
        
        /// <summary>
        /// 注销用户删除登录记录
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public int DeleteUserLogin(string UserName)
        {
            string sql = "DELETE FROM tbUserLoginInfo WHERE UserName ='" + UserName + "'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 更新用户名
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="NewUserName"></param>
        /// <returns></returns>
        public int UpdateUserName(string UserName ,string NewUserName)
        {
            string sql = "UPDATE [dbo].[tbUserInfo]SET" +
                                      "[UserName] ='" + NewUserName + @"'
                                  WHERE UserName = '" + UserName + @"'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 更新登录下拉框用户名
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="NewUserName"></param>
        /// <returns></returns>
        public int UpdateUserLoginName(string UserName, string NewUserName)
        {
            string sql = "UPDATE [dbo].[tbUserLoginInfo]SET" +
                                      "[UserName] ='" + NewUserName + @"'
                                  WHERE UserName = '" + UserName + @"'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 更新密保问题
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public int UpdatePwdQuestion(User objUser)
        {
            string sql = "UPDATE [dbo].[tbUserInfo]SET" +
                                      "[PwdQuestion] ='" + objUser.PwdQuestion + @"'
                                      ,[PwdAnswer] = '" + objUser.PwdAnswer + @"'
                                  WHERE UserName = '" + objUser.UserName + @"'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 判断用户密码和密保是否存在
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <param name="PwdQuestion"></param>
        /// <param name="PwdAnswer"></param>
        /// <returns></returns>
        public bool IsUserPwdAndQuestionExisted(string UserName,string UserPwd, string PwdQuestion, string PwdAnswer)
        {
            string sql = "SELECT COUNT(*) FROM tbUserInfo WHERE UserName = '" + UserName + "'AND UserPwd ='" + UserPwd + "'" +
                "AND PwdQuestion ='" + PwdQuestion + "'AND PwdAnswer ='" + PwdAnswer + "'";
            sql = string.Format(sql, UserName, UserPwd, PwdQuestion, PwdAnswer);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return false;
            else return true;
        }

        /// <summary>
        /// 通过用户名查询密码
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public User GetUserPwd(string UserName)
        {
            string sql = "SELECT UserPwd FROM tbUserInfo WHERE UserName ='" + UserName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            User objUser = null;
            if (objReader.Read())
            {
                objUser = new User()
                {
                    UserPwd = objReader["UserPwd"].ToString()
                };
            }
            objReader.Close();
            return objUser;
        }

        /// <summary>
        /// 更新用户名是否记住密码
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public int UpdateRemberPwd(User objUser)
        {
            User user = new User();
            string sql = @"UPDATE[dbo].[tbUserInfo]
                                   SET[RemberPwd]='" + objUser.RemberPwd + @"'
                                   WHERE UserName ='" + objUser.UserName + "'";
            return SQLHelper.Update(sql);
        }

        /// <summary>
        /// 查找用户是否记住密码
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public User GetRemberPwd(string UserName)
        {
            string sql = "SELECT RemberPwd FROM tbUserInfo WHERE UserName ='" + UserName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            User objUser = null;
            if (objReader.Read())
            {
                objUser = new User()
                {
                    RemberPwd = Convert.ToInt32(objReader["RemberPwd"].ToString())
                };
            }
            objReader.Close();
            return objUser;
        }

        /// <summary>
        /// 更新用户是否自动登录
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public int UpdateAutomaticlogon(User objUser)
        {
            User user = new User();
            string sql = @"UPDATE[dbo].[tbUserInfo]
                                   SET[Automaticlogon]='" + objUser.Automaticlogon + @"'
                                   WHERE UserName ='" + objUser.UserName + "'";
            return SQLHelper.Update(sql);
        }

        public User GetAutomaticlogon(string UserName)
        {
            string sql = "SELECT Automaticlogon FROM tbUserInfo WHERE UserName ='" + UserName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            User objUser = null;
            if (objReader.Read())
            {
                objUser = new User()
                {
                    Automaticlogon = Convert.ToInt32(objReader["Automaticlogon"].ToString())
                };
            }
            objReader.Close();
            return objUser;
        }
    }
}
