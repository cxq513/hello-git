using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Models;
using Models.Ext;
using DAL;

namespace DAL
{
    /// <summary>
    /// 学生信息访问类
    /// </summary>
    public class StudentService
    {
        /// <summary>
        /// 验证身份证号是否存在
        /// </summary>
        /// <param name="IDNumber"></param>
        /// <returns></returns>
        public bool IsIDNumberExisted(string IDNumber)
        {
            string sql = "SELECT COUNT(*) FROM tbStudentInfo WHERE IDnumber = '{0}'";
            sql = string.Format(sql, IDNumber);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 查询学号是否存在
        /// </summary>
        /// <param name="StudentNumber"></param>
        /// <returns></returns>
        public bool IsStudentNumberExisted(string StudentNumber)
        {
            string sql = "SELECT COUNT(*) FROM tbStudentInfo WHERE StudentNumber = '{0}'";
            sql = string.Format(sql, StudentNumber);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 添加学生对象
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int AddStudent(Student objStudent)
        {
            Student student = new Student();
            string sql = @"INSERT INTO[dbo].[tbStudentInfo]
                      ([StudentNumber]
                      ,[StudentName]
                      ,[StudentSex]
                      ,[StudentBrithday]
                      ,[IDnumber]
                      ,[StudentPhoneNumber]
                      ,[StudentNation]
                      ,[StudentNativeplace]
                      ,[StudentAddress]
                      ,[StudentPolitical]
                      ,[StudentCollage]
                      ,[SpecialityName]
                      ,[ClassName]
                      ,[ClassID]
                      ,[StudentJob]
                      ,[StudentPwd]
                      ,[StudentPhoto])
                VALUES
                      ('" + objStudent.StudentNumber + @"'
                      ,'" + objStudent.StudentName + @"'
                      ,'" + objStudent.StudentSex + @"'
                      ,'" + objStudent.StudentBrithday + @"'
                      ,'" + objStudent.IDnumber + @"'
                      ,'" + objStudent.StudentPhoneNumber + @"'
                      ,'" + objStudent.StudentNation + @"'
                      ,'" + objStudent.StudentNativeplace + @"'
                      ,'" + objStudent.StudentAddress + @"'
                      ,'" + objStudent.StudentPolitical + @"'
                      ,'" + objStudent.StudentCollage + @"'
                      ,'" + objStudent.SpecialityName + @"'
                      ,'" + objStudent.ClassName + @"'
                      ,'" + objStudent.ClassID + @"'
                      ,'" + objStudent.StudentJob + @"'
                      ,'" + objStudent.StudentPwd + @"'
                      ,'" + objStudent.StudentPhoto + "')";
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
        /// 根据班级查学生信息
        /// </summary>
        /// <returns></returns>
        public List<StudentExt> GetStudentByClassID(string ClassID)
        {
            string sql = "SELECT StudentNumber,StudentName,StudentSex,tbStudentInfo.ClassName,StudentBrithday," +
                "StudentNativeplace,StudentPhoneNumber,StudentNation,StudentPolitical,tbStudentInfo.SpecialityName," +
                "IDnumber,StudentPwd,StudentCollage,StudentAddress,StudentJob,StudentPhoto FROM tbStudentInfo";
            sql += " INNER JOIN tbClassInfo ON tbStudentInfo.ClassID = tbClassInfo.ClassID";
            sql += " WHERE tbStudentInfo.ClassID=" + ClassID;
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<StudentExt> list = new List<StudentExt>();
            while (objReader.Read())
            {
                list.Add(new StudentExt()
                {
                    //StudentID = Convert.ToInt32(objReader["StudentID"]),
                    StudentNumber = objReader["StudentNumber"].ToString(),
                    StudentName = objReader["StudentName"].ToString(),
                    StudentSex = objReader["StudentSex"].ToString(),
                    ClassName = objReader["ClassName"].ToString(),
                    StudentBrithday = Convert.ToDateTime(objReader["StudentBrithday"]),
                    StudentNativeplace = objReader["StudentNativeplace"].ToString(),
                    StudentPhoneNumber = objReader["StudentPhoneNumber"].ToString(),
                    StudentNation = objReader["StudentNation"].ToString(),
                    StudentPolitical = objReader["StudentPolitical"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    IDnumber = objReader["IDnumber"].ToString(),
                    StudentCollage = objReader["StudentCollage"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString(),
                    StudentJob = objReader["StudentJob"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 根据学号查询学生对象
        /// </summary>
        /// <param name="StudentNumber"></param>
        /// <returns></returns>
        public Student GetStudent(string StudentNumber)
        {
            string sql = "SELECT StudentID,StudentNumber,StudentName,StudentSex,tbStudentInfo.ClassName,StudentBrithday," +
                "StudentNativeplace,StudentPhoneNumber,StudentNation,StudentPolitical,tbStudentInfo.SpecialityName," +
                "IDnumber,StudentPwd,StudentCollage,StudentAddress,StudentJob,StudentPhoto FROM tbStudentInfo";
            sql += " WHERE StudentNumber='" + StudentNumber + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Student objStudent = null;
            if (objReader.Read())
            {
                objStudent = new Student()
                {
                    StudentID = Convert.ToInt32(objReader["StudentID"]),
                    StudentNumber = objReader["StudentNumber"].ToString(),
                    StudentName = objReader["StudentName"].ToString(),
                    StudentSex = objReader["StudentSex"].ToString(),
                    ClassName = objReader["ClassName"].ToString(),
                    StudentBrithday = Convert.ToDateTime(objReader["StudentBrithday"]),
                    StudentNativeplace = objReader["StudentNativeplace"].ToString(),
                    StudentPhoneNumber = objReader["StudentPhoneNumber"].ToString(),
                    StudentNation = objReader["StudentNation"].ToString(),
                    StudentPolitical = objReader["StudentPolitical"].ToString(),
                    SpecialityName = objReader["SpecialityName"].ToString(),
                    IDnumber = objReader["IDnumber"].ToString(),
                    StudentCollage = objReader["StudentCollage"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString(),
                    StudentJob = objReader["StudentJob"].ToString(),
                    StudentPhoto = objReader["StudentPhoto"] is DBNull ? "" : objReader["StudentPhoto"].ToString()
                };
            }
            objReader.Close();
            return objStudent;
        }

        /// <summary>
        /// 级联学院下拉框，动态填充专业下拉框
        /// </summary>
        /// <param name="SpecialityID"></param>
        /// <returns></returns>
        public DataSet GetSpecialityNameByCollageID(string CollageID)
        {
            string sql = "SELECT SpecialityID,SpecialityName FROM tbSpecialityInfo ";
            sql += " INNER JOIN tbCollageInfo ON tbSpecialityInfo.CollageID = tbCollageInfo.CollageID";
            sql += " WHERE tbSpecialityInfo.CollageID=" + CollageID;
            return SQLHelper.GetDataSet(sql);
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
        /// 修改学生时判断身份证号是否和其他学生相同
        /// </summary>
        /// <param name="IDNumber"></param>
        /// <param name="StudentNumber"></param>
        /// <returns></returns>
        public bool IsIDNumberNoExisted(string IDNumber, string StudentNumber)
        {
            string sql = "SELECT COUNT(*) FROM tbStudentInfo WHERE IDNumber='" + IDNumber + "'AND StudentNumber<>'" + StudentNumber + "'";
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            else return false;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
            public int UpdateStudent(Student objStudent)
            {
            //StringBuilder sqlBuilder = new StringBuilder();
            string sql = @"UPDATE[dbo].[tbStudentInfo]
                                       SET[StudentNumber] = '" + objStudent.StudentNumber + @"'
                                          ,[StudentName] = '" + objStudent.StudentName + @"'
                                          ,[StudentSex] = '" + objStudent.StudentSex + @"'
                                          ,[StudentBrithday] = '" + objStudent.StudentBrithday + @"'
                                          ,[IDnumber] = '" + objStudent.IDnumber + @"'
                                          ,[StudentPhoneNumber] = '" + objStudent.StudentPhoneNumber + @"' 
                                          ,[StudentNation] = '" + objStudent.StudentNation + @"' 
                                          ,[StudentNativeplace] = '" + objStudent.StudentNativeplace + @"' 
                                          ,[StudentAddress] = '" + objStudent.StudentAddress + @"' 
                                          ,[StudentPolitical] = '" + objStudent.StudentPolitical + @"' 
                                          ,[StudentCollage] = '" + objStudent.StudentCollage + @"' 
                                          ,[StudentJob] = '" + objStudent.StudentJob + @"' 
                                          ,[StudentPwd] = '" + objStudent.StudentPwd + @"' 
                                          ,[StudentPhoto] = '" + objStudent.StudentPhoto + @"' 
                                          ,[ClassID] = '" + objStudent.ClassID + @"' 
                                          ,[SpecialityName] = '" + objStudent.SpecialityName + @"' 
                                          ,[ClassName] = '" + objStudent.ClassName + @"' 
                                     WHERE StudentNumber = '" + objStudent.StudentNumber + @"'";
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
        /// 删除学生信息
        /// </summary>
        /// <param name="StudentNumber"></param>
        /// <returns></returns>
        public int DeleteStudent(string StudentNumber)
        {
            string sql = "DELETE FROM tbStudentInfo WHERE StudentNumber='" + StudentNumber + "'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("当前学号被其他数据引用，不能直接被删除！");
                }
                else
                {
                    throw new Exception("删除学生对象发生错误:" + ex.Message);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("删除学生对象发生错误:" + ex.Message);
            }
        }
    }
}
