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
    /// 专业信息访问类
    /// </summary>
    public class SpecialityService
    {
        /// <summary>
        /// 获取所有的专业对象
        /// </summary>
        /// <returns></returns>
        public List<Speciality> GetAllSpeciality()
        {
            string sql = "SELECT SpecialityID,SpecialityName,CollageName FROM tbSpecialityInfo  ";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Speciality> list = new List<Speciality>();
            while (objReader.Read())
            {
                list.Add(new Speciality()
                {
                    SpecialityID = Convert.ToInt32(objReader["SpecialityID"]),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    CollageName = objReader["CollageName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 验证专业编号是否存在
        /// </summary>
        /// <param name="SpecialityID"></param>
        /// <returns></returns>
        public bool IsSpecialityIDExisted(string SpecialityID)
        {
            string sql = "SELECT COUNT(*) FROM tbSpecialityInfo WHERE SpecialityID = '{0}'";
            sql = string.Format(sql, SpecialityID);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 查询专业是否存在
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <returns></returns>
        public bool IsSpecialityNameExisted(string SpecialityName)
        {
            string sql = "SELECT COUNT(*) FROM tbSpecialityInfo WHERE SpecialityName = '{0}'";
            sql = string.Format(sql, SpecialityName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 添加专业对象
        /// </summary>
        /// <param name="objSpeciality"></param>
        /// <returns></returns>
        public int AddSpeciality(Speciality objSpeciality)
        {
            Speciality Speciality = new Speciality();
            Speciality  = new Speciality();

            string sql = @"INSERT INTO[dbo].[tbSpecialityInfo]
                                   ([SpecialityName]
                                   ,[CollageName]
                                   ,[CollageID]
                                   ,[Remark])
                             VALUES
                                   ('" + objSpeciality.SpecialityName + @"'
                                   ,'" + objSpeciality.CollageName + @"'
                                   ,'" + objSpeciality.CollageID + @"'
                                   ,'" + objSpeciality.Remark + "')";
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
        /// 动态获取专业
        /// </summary>
        /// <returns></returns>
        public DataSet GetSpeciality ()
        {
            string sql = "SELECT  SpecialityID,SpecialityName FROM tbSpecialityInfo";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 查询专业对象并打包
        /// </summary>
        /// <returns></returns>
        public List<Speciality> GetSpecialityBag()
        {
            string sql = "SELECT CollageName,SpecialityID,SpecialityName,Remark FROM tbSpecialityInfo";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Speciality> list = new List<Speciality>();
            while (objReader.Read())
            {
                list.Add(new Speciality()
                {
                    SpecialityID = Convert.ToInt32(objReader["SpecialityID"].ToString()),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    CollageName = objReader["CollageName"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 根据专业名查询专业对象
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <returns></returns>
        public Speciality GetSpecialityBySpecialityName(string SpecialityName)
        {
            string sql = "SELECT SpecialityID,SpecialityName,Remark,CollageName FROM tbSpecialityInfo";
            sql += " WHERE SpecialityName='" + SpecialityName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Speciality objSpeciality = null;
            if (objReader.Read())
            {
                objSpeciality = new Speciality()
                {
                    CollageName = objReader["CollageName"].ToString(),
                    SpecialityID = Convert.ToInt32(objReader["SpecialityID"].ToString()),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                };
            }
            objReader.Close();
            return objSpeciality;
        }

        /// <summary>
        /// 修改专业信息
        /// </summary>
        /// <param name="objSpeciality"></param>
        /// <returns></returns>
        public int UpdateSpeciality(Speciality objSpeciality)
        {
            string sql = "UPDATE [dbo].[tbSpecialityInfo]SET" +
                                      "[SpecialityName] ='" + objSpeciality.SpecialityName + @"'
                                      ,[CollageName] = '" + objSpeciality.CollageName + @"'
                                      ,[Remark] = '" + objSpeciality.Remark + @"'
                                  WHERE SpecialityName = '" + objSpeciality.SpecialityName + @"'";
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
        /// 删除专业信息
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <returns></returns>
        public int DeleteSpeciality(string SpecialityName)
        {
            string sql = "DELETE FROM tbSpecialityInfo WHERE SpecialityName='" + SpecialityName + "'";
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
