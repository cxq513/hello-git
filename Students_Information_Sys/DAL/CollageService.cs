using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// 学院信息访问类
    /// </summary>
    public class CollageService
    {
        /// <summary>
        /// 获取所有的学院对象
        /// </summary>
        /// <returns></returns>
        public List<Collage> GetAllCollage()
        {
            string sql = "SELECT CollageID,CollageName FROM tbCollageInfo";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Collage> list = new List<Collage>();
            while (objReader.Read())
            {
                list.Add(new Collage()
                {
                    CollageID = Convert.ToInt32(objReader["CollageID"]),
                    CollageName = objReader["CollageName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 动态获取学院
        /// </summary>
        /// <returns></returns>
        public DataSet GetCollage()
        {
            string sql = "SELECT  CollageID,CollageName FROM tbCollageInfo";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 查询学院是否存在
        /// </summary>
        /// <param name="CollageName"></param>
        /// <returns></returns>
        public bool IsCollageNameExisted(string CollageName)
        {
            string sql = "SELECT COUNT(*) FROM tbCollageInfo WHERE CollageName = '{0}'";
            sql = string.Format(sql, CollageName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 添加学院对象
        /// </summary>
        /// <param name="objCollage"></param>
        /// <returns></returns>
        public int AddCollage(Collage objCollage)
        {
            Collage collage = new Collage();

            string sql = @"INSERT INTO[dbo].[tbCollageInfo]
                                   ([CollageName]
                                   ,[Remark])
                             VALUES
                                   ('" + objCollage.CollageName + @"'
                                   ,'" + objCollage.Remark + "')";
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
        /// 学院对象并打包
        /// </summary>
        /// <returns></returns>
        public List<Collage> GetCollageBagByCollageName()
        {
            string sql = "SELECT CollageID,CollageName,Remark FROM tbCollageInfo";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Collage> list = new List<Collage>();
            while (objReader.Read())
            {
                list.Add(new Collage()
                {
                    CollageID = Convert.ToInt32(objReader["CollageID"].ToString()),
                    CollageName = objReader["CollageName"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 根据学院名查询学院对象
        /// </summary>
        /// <param name="CollageName"></param>
        /// <returns></returns>
        public Collage GetCollageByCollageName(string CollageName)
        {
            string sql = "SELECT CollageID,CollageName,Remark FROM tbCollageInfo";
            sql += " WHERE CollageName='" + CollageName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Collage objCollage = null;
            if (objReader.Read())
            {
                objCollage = new Collage()
                {
                    CollageID = Convert.ToInt32(objReader["CollageID"].ToString()),
                    CollageName = objReader["CollageName"].ToString(),
                    Remark = objReader["Remark"].ToString(),
                };
            }
            objReader.Close();
            return objCollage;
        }

        /// <summary>
        /// 修改学院信息
        /// </summary>
        /// <param name="objCollage"></param>
        /// <returns></returns>
        public int UpdateCollage(Collage objCollage)
        {
            string sql = "UPDATE [dbo].[tbCollageInfo]SET" +
                                      "[CollageName] ='" + objCollage.CollageName + @"'
                                      ,[Remark] = '" + objCollage.Remark + @"'
                                  WHERE CollageName = '" + objCollage.CollageName + @"'";
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
        /// 删除学院信息
        /// </summary>
        /// <param name="CollageName"></param>
        /// <returns></returns>
        public int DeleteCollage(string CollageName)
        {
            string sql = "DELETE FROM tbCollageInfo WHERE CollageName='" + CollageName + "'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("当前学院被其他数据引用，不能直接被删除！");
                }
                else
                {
                    throw new Exception("删除学院对象发生错误:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("删除学院对象发生错误:" + ex.Message);
            }
        }
    }
}
