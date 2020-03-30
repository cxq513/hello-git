using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DAL;
using Models;

namespace DAL
{
    /// <summary>
    /// 班级信息访问类
    /// </summary>
    public class ClassService
    {

        /// <summary>
        /// 获取所有的班级对象
        /// </summary>
        /// <returns></returns>
        public List<Class> GetAllClass()
        {
            string sql = "SELECT ClassID,ClassName,EnrolmentTime FROM tbClassInfo";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Class> list = new List<Class>();
            while (objReader.Read())
            {
                list.Add(new Class()
                {
                    ClassID = Convert.ToInt32(objReader["ClassID"]),
                    ClassName = objReader["ClassName"].ToString(),
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"])
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 验证专业是否存在
        /// </summary>
        /// <param name="ClassID"></param>
        /// <returns></returns>
        public bool IsSpecialityNameExisted(string SpecialityName)
        {
            string sql = "SELECT COUNT(*) FROM tbClassInfo WHERE SpecialityName = '{0}'";
            sql = string.Format(sql, SpecialityName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count >= 1) return true;
            else return false;
        }

        /// <summary>
        /// 查询班级是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool IsClassNameExisted(string ClassName )
        {
            string sql = "SELECT COUNT(*) FROM tbClassInfo WHERE ClassName = '{0}'";
            sql = string.Format(sql, ClassName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count >= 1) return true;
            else return false;
        }

        /// <summary>
        /// 添加班级对象
        /// </summary>
        /// <param name="objClass"></param>
        /// <returns></returns>
        public int AddClass(Class objClass)
        {
            Class Class = new Class();

            string sql = @"INSERT INTO[dbo].[tbClassInfo]
                                   ([ClassName]
                                   ,[ClassNum]
                                   ,[SchoolReform]  
                                   ,[HeadTeacher]
                                   ,[EnrolmentTime]
                                   ,[Remark]
                                   ,[SpecialityID]
                                   ,[SpecialityName])
                             VALUES
                                   ('" + objClass.ClassName + @"'
                                   ,'" + objClass.ClassNum + @"'
                                   ,'" + objClass.SchoolReform + @"'
                                   ,'" + objClass.HeadTeacher + @"'
                                   ,'" + objClass.EnrolmentTime + @"'
                                   ,'" + objClass.Remark + @"'
                                   ,'" + objClass.SpecialtyID + @"'
                                   ,'" + objClass.SpecialityName + "')";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("保存数据出现问题！" + ex.Message);
            }
        }

        /// <summary>
        /// 根据专业查班级信息
        /// </summary>
        /// <returns></returns>
        public List<Class> GetSpecialityID(string SpecialityID)
        {
            string sql = "SELECT  tbClassInfo.ClassID,ClassName,ClassNum,SchoolReform,HeadTeacher," +
                         "EnrolmentTime,tbClassInfo.Remark,tbClassInfo.SpecialityName FROM tbClassInfo";
            sql += " INNER JOIN tbSpecialityInfo ON tbClassInfo.SpecialityID = tbSpecialityInfo.SpecialityID";
            sql += " WHERE tbClassInfo.SpecialityID=" + SpecialityID;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Class> list = new List<Class>();
            while (objReader.Read())
            {
                list.Add(new Class()
                {
                    ClassID = Convert.ToInt32(objReader["ClassID"]),
                    ClassName = objReader["ClassName"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    ClassNum = objReader["ClassNum"].ToString(),
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"]),
                    HeadTeacher = objReader["HeadTeacher"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                    SchoolReform = Convert.ToInt32(objReader["SchoolReform"]),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 查询按照入学时间查找班级是否存在
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <param name="EnrolmentTime"></param>
        /// <returns></returns>
        public bool IsClassByTimeExisted(string SpecialityName, string EnrolmentTime)
        {
            string sql = "SELECT COUNT(*) FROM tbClassInfo WHERE SpecialityName = '{0}' AND EnrolmentTime = '{1}'";
            sql = string.Format(sql, SpecialityName, EnrolmentTime);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 根据专业名称和入学时间查询班级信息并打包
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <param name="EnrolmentTime"></param>
        /// <returns></returns>
        public List<Class> GetClassListBySpecialityNameAndEnrolmentTime(string SpecialityName, string EnrolmentTime)
        {
            string sql = "SELECT  tbClassInfo.ClassID,ClassName,ClassNum,SchoolReform,HeadTeacher," +
                         "EnrolmentTime,tbClassInfo.Remark,tbClassInfo.SpecialityName FROM tbClassInfo";
            sql += " WHERE tbClassInfo.SpecialityName='" + SpecialityName + "'AND EnrolmentTime='" + EnrolmentTime + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Class> list = new List<Class>();
            while (objReader.Read())
            {
                list.Add(new Class()
                {
                    ClassID = Convert.ToInt32(objReader["ClassID"]),
                    ClassName = objReader["ClassName"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    ClassNum = objReader["ClassNum"].ToString(),
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"]),
                    HeadTeacher = objReader["HeadTeacher"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                    SchoolReform = Convert.ToInt32(objReader["SchoolReform"]),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 根据专业名称和入学时间查询班级信息
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <param name="EnrolmentTime"></param>
        /// <returns></returns>
        public Class GetClassBySpecialityNameAndEnrolmentTime(string SpecialityName, string EnrolmentTime)
        {
            string sql = "SELECT  tbClassInfo.ClassID,ClassName,ClassNum,SchoolReform,HeadTeacher," +
                         "EnrolmentTime,tbClassInfo.Remark,tbClassInfo.SpecialityName FROM tbClassInfo";
            sql += " WHERE tbClassInfo.SpecialityName='" + SpecialityName + "'AND EnrolmentTime='" + EnrolmentTime + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql); 
            Class objClass = null;
            if (objReader.Read())
            {
                objClass = new Class()
                {
                    ClassID = Convert.ToInt32(objReader["ClassID"]),
                    ClassName = objReader["ClassName"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    ClassNum = objReader["ClassNum"].ToString(),
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"]),
                    HeadTeacher = objReader["HeadTeacher"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                    SchoolReform = Convert.ToInt32(objReader["SchoolReform"]),
                };
            }
            objReader.Close();
            return objClass;
        }
        
        /// <summary>
        /// 按照班级名称打包班级信息
        /// </summary>
        /// <returns></returns>
        public List<Class>GetClassesBagByClassName()
        {
            string sql = "SELECT ClassID,ClassName,ClassID,ClassNum,SchoolReform,HeadTeacher,EnrolmentTime," +
                         "Remark,SpecialityName FROM tbClassInfo";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Class> list = new List<Class>();
            while (objReader.Read())
            {
                list.Add(new Class()
                {
                    ClassID = Convert.ToInt32(objReader["ClassID"]),
                    ClassName = objReader["ClassName"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    ClassNum = objReader["ClassNum"].ToString(),
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"]),
                    HeadTeacher = objReader["HeadTeacher"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                    SchoolReform = Convert.ToInt32(objReader["SchoolReform"]),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 级联专业下拉框，动态填充班级下拉框
        /// </summary>
        /// <param name="SpecialityID"></param>
        /// <returns></returns>
        public DataSet GetClassNameBySpecialityID(string SpecialityID)
        {
            string sql = "SELECT ClassID,ClassName FROM tbClassInfo ";
            sql += " INNER JOIN tbSpecialityInfo ON tbClassInfo.SpecialityID = tbSpecialityInfo.SpecialityID";
            sql += " WHERE tbClassInfo.SpecialityID=" + SpecialityID;
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 通过班级名称查询班级
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public Class GetClass(string ClassName)
        {
            string sql = "SELECT ClassName,SpecialityName,ClassNum,SchoolReform,HeadTeacher,EnrolmentTime,Remark FROM tbClassInfo WHERE ClassName ='" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Class objClass = null;
            if (objReader.Read())
            {
                objClass = new Class()
                {
                    ClassName = objReader["ClassName"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    ClassNum = objReader["ClassNum"].ToString(),
                    SchoolReform = Convert.ToInt32(objReader["SchoolReform"].ToString()),
                    HeadTeacher = objReader["HeadTeacher"].ToString(),
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"]),
                    Remark = objReader["Remark"].ToString()
                };
            }
            objReader.Close();
            return objClass;
        }

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="objClass"></param>
        /// <returns></returns>
        public int UpdateClass(Class objClass)
        {
            string sql = "UPDATE [dbo].[tbClassInfo]SET" +
                                      "[ClassName] ='" + objClass.ClassName + @"'
                                      ,[Remark] = '" + objClass.Remark + @"'
                                      ,[ClassNum] = '" + objClass.ClassNum + @"'
                                      ,[HeadTeacher] = '" + objClass.HeadTeacher + @"'
                                      ,[EnrolmentTime] = '" + objClass.EnrolmentTime + @"'
                                      ,[SchoolReform] = '" + objClass.SchoolReform + @"'
                                  WHERE ClassName = '" + objClass.ClassName + @"'";
            try
            {
                return Convert.ToInt32(SQLHelper.Update(sql));//执行sql语句，返回结果
            }
            catch (SqlException ex)
            {
                throw new Exception("数据库操作异常！具体信息:\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public int DeleteClass(string ClassName)
        {
            string sql = "DELETE FROM tbClassInfo WHERE ClassName ='"+ ClassName +"'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {

                if (ex.Number == 547)
                {
                    throw new Exception("当前专业被其他数据引用，不能直接被删除！");
                }
                else
                {
                    throw new Exception("删除专业对象发生错误:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("删除专业对象发生错误:" + ex.Message);
            }
        }
    }
 }
