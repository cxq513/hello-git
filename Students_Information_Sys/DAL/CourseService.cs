using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 课程信息访问类
    /// </summary>
    public class CourseService
    {

        /// <summary>
        /// 动态获取专业
        /// </summary>
        /// <returns></returns>
        public DataSet GetSpeciality()
        {
            string sql = "SELECT  SpecialityID,SpecialityName FROM tbSpecialityInfo";
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
        /// 根据班级名称查询入学时间
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public Class GetEnrolmentTime(string ClassName)
        {
            string sql = "SELECT EnrolmentTime,ClassID FROM tbClassInfo WHERE ClassName='" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Class objClass = null;
            if (objReader.Read())
            {
                objClass = new Class()
                {
                    EnrolmentTime = Convert.ToDateTime(objReader["EnrolmentTime"]),
                    ClassID = Convert.ToInt32(objReader["ClassID"])
                };
            }
            objReader.Close();
            return objClass;
        }

        /// <summary>
        /// 添加课程对象
        /// </summary>
        /// <param name="objCourse"></param>
        /// <returns></returns>
        public int AddCourse(Course objCourse)
        {
            Course Course = new Course();
            string sql = @"INSERT INTO[dbo].[tbCourseInfo]
                                       ([CourseName]
                                      ,[Semester]
                                      ,[ClassID]
                                      ,[Teacher]
                                      ,[TeacherPhoneNumber]
                                      ,[ClassName])
                                VALUES
                                      ('" + objCourse.CourseName + @"'
                                      ,'" + objCourse.Semester + @"'
                                      ,'" + objCourse.ClassID + @"'
                                      ,'" + objCourse.Teacher + @"'
                                      ,'" + objCourse.TeacherPhoneNumber + @"'
                                      ,'" + objCourse.ClassName + "')";
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
        /// 查询所有学院名称打包
        /// </summary>
        /// <returns></returns>
        public List<Collage> GetCollageName()
        {
            string sql = "SELECT CollageName FROM tbCollageInfo";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Collage> list = new List<Collage>();
            while (objReader.Read())
            {
                list.Add(new Collage()
                {
                    CollageName = objReader["CollageName"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 通过学院名称查询专业名称并打包
        /// </summary>
        /// <returns></returns>
        public List<Speciality> GetSpecialitiesName(string CollageName)
        {
            string sql = "SELECT SpecialityName FROM tbSpecialityInfo WHERE tbSpecialityInfo.CollageName='" + CollageName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Speciality> list = new List<Speciality>();
            while (objReader.Read())
            {
                list.Add(new Speciality()
                {
                    SpecialityName = objReader["SpecialityName"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 查询课程是否存在
        /// </summary>
        /// <param name="CourseName"></param>
        /// <param name="Semester"></param>
        /// <param name="Teacher"></param>
        /// <returns></returns>
        public bool IsCourseExisted(string CourseName, string Semester, string ClassName)
        {
            string sql = "SELECT COUNT(*) FROM tbCourseInfo WHERE CourseName = '{0}' AND Semester ='{1}' AND ClassName ='{2}'";
            sql = string.Format(sql, CourseName, Semester, ClassName);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 通过专业名称查询班级名称并打包
        /// </summary>
        /// <param name="SpecialityName"></param>
        /// <returns></returns>
        public List<Class> GetClassName(string SpecialityName)
        {
            string sql = "SELECT ClassName FROM tbClassInfo WHERE tbClassInfo.SpecialityName='" + SpecialityName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Class> list = new List<Class>();
            while (objReader.Read())
            {
                list.Add(new Class()
                {
                    ClassName = objReader["ClassName"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }
        
        /// <summary>
        /// 通过班级名称查询学期并打包
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public List<Course> GetSemester(string ClassName)
        {
            string sql = "SELECT DISTINCT Semester FROM tbCourseInfo  WHERE tbCourseInfo.ClassName='" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Course> list = new List<Course>();
            while (objReader.Read())
            {
                list.Add(new Course()
                {
                    Semester = objReader["Semester"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 通过学期查询课程并打包
        /// </summary>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public List<Course> GetCourseName(string Semester,string ClassName)
        {
            string sql = "SELECT CourseName FROM tbCourseInfo  WHERE tbCourseInfo.Semester='" + Semester + "' AND ClassName ='"+ ClassName +"'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Course> list = new List<Course>();
            while (objReader.Read())
            {
                list.Add(new Course()
                {
                    CourseName = objReader["CourseName"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 通过班级名称/学期/课程名称查询课程信息打包（浏览用）
        /// </summary>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public List<Course> GetCourseBag(string CourseName, string Semester, string ClassName)
        {
            string sql = "SELECT ClassName,CourseName,Semester,Teacher,TeacherPhoneNumber FROM tbCourseInfo  " +
                         "WHERE tbCourseInfo.CourseName='" + CourseName + "' AND Semester='" + Semester + "' " +
                         "AND ClassName='" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Course> list = new List<Course>();
            while (objReader.Read())
            {
                list.Add(new Course()
                {
                    ClassName = objReader["ClassName"].ToString(),
                    CourseName = objReader["CourseName"].ToString(),
                    Semester = objReader["Semester"].ToString(),
                    Teacher = objReader["Teacher"].ToString(),
                    TeacherPhoneNumber = objReader["TeacherPhoneNumber"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 通过班级名称/学期查询课程信息打包（浏览用）
        /// </summary>
        /// <param name="Semester"></param>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public List<Course> GetCourseBag1(string Semester, string ClassName)
        {
            string sql = "SELECT ClassName,CourseName,Semester,Teacher,TeacherPhoneNumber FROM tbCourseInfo  " +
                         "WHERE ClassName='" + ClassName + "'AND Semester='" + Semester + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Course> list = new List<Course>();
            while (objReader.Read())
            {
                list.Add(new Course()
                {
                    ClassName = objReader["ClassName"].ToString(),
                    CourseName = objReader["CourseName"].ToString(),
                    Semester = objReader["Semester"].ToString(),
                    Teacher = objReader["Teacher"].ToString(),
                    TeacherPhoneNumber = objReader["TeacherPhoneNumber"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 通过班级名称查询课程信息打包（浏览用）
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public List<Course> GetCourseBag2(string ClassName)
        {
            string sql = "SELECT ClassName,CourseName,Semester,Teacher,TeacherPhoneNumber FROM tbCourseInfo  " +
                         "WHERE ClassName='" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Course> list = new List<Course>();
            while (objReader.Read())
            {
                list.Add(new Course()
                {
                    ClassName = objReader["ClassName"].ToString(),
                    CourseName = objReader["CourseName"].ToString(),
                    Semester = objReader["Semester"].ToString(),
                    Teacher = objReader["Teacher"].ToString(),
                    TeacherPhoneNumber = objReader["TeacherPhoneNumber"].ToString(),
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 通过班级名称查询学期（修改/删除课程用）
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public DataSet GetSemesterForUpdate(string ClassID)
        {
            string sql = "SELECT DISTINCT Semester FROM tbCourseInfo  WHERE tbCourseInfo.ClassID='" + ClassID + "'";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 通过学期查询课程名称（修改/删除课程用）
        /// </summary>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public DataSet GetCourseNameForUpdate(string Semester,string ClassName)
        {
            string sql = "SELECT  CourseName FROM tbCourseInfo  WHERE tbCourseInfo.Semester='" + Semester + "' AND ClassName='" + ClassName + "'";
            return SQLHelper.GetDataSet(sql);
        }

        /// <summary>
        /// 通过课程查找课程信息（任课老师，联系方式（修改/删除课程用））
        /// </summary>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        public Course GetCourse(string CourseName,string ClassName, string Semester)
        {
            string sql = "SELECT Teacher,TeacherPhoneNumber FROM tbCourseInfo";
            sql += " WHERE CourseName='" + CourseName + "' AND ClassName = '" + ClassName + "' AND Semester = '" + Semester + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Course objCourse = null;
            if (objReader.Read())
            {
                objCourse = new Course()
                {
                    Teacher = objReader["Teacher"].ToString(),
                    TeacherPhoneNumber = objReader["TeacherPhoneNumber"].ToString(),
                };
            }
            objReader.Close();
            return objCourse;
        }

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="objCourse"></param>
        /// <returns></returns>
        public int UpdateCourse(Course objCourse)
        {
            string sql = @"UPDATE[dbo].[tbCourseInfo]
                            SET[ClassID] ='" + objCourse.ClassID + @"'
                              ,[ClassName] = '" + objCourse.ClassName + @"'
                              ,[Semester] = '" + objCourse.Semester + @"'
                              ,[CourseName] = '" + objCourse.CourseName + @"'
                              ,[Teacher] = '" + objCourse.Teacher + @"'
                              ,[TeacherPhoneNumber] = '" + objCourse.TeacherPhoneNumber + @"'
                         WHERE CourseName='" + objCourse.CourseName + "' AND ClassName = '" + objCourse.ClassName + "' AND Semester = '" + objCourse.Semester + "'";
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
        /// 删除课程信息
        /// </summary>
        /// <param name="CourseName"></param>
        /// <param name="Semester"></param>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public int DeleteCourse(string CourseName,string Semester,string ClassName)
        {
            string sql = "DELETE FROM tbCourseInfo WHERE CourseName='" + CourseName + "' AND Semester='" + Semester + "' AND ClassName='" + ClassName + "'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("当前课程被其他数据引用，不能直接被删除！");
                }
                else
                {
                    throw new Exception("删除课程对象发生错误:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("删除课程对象发生错误:" + ex.Message);
            }
        }

        /// <summary>
        /// 通过班级名称AND学期AND课程名查询课程信息（浏览修改/删除用）
        /// </summary>
        /// <param name="CourseName"></param>
        /// <param name="ClassName"></param>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public Course GetCourseByBrowse(string CourseName, string ClassName, string Semester)
        {
            string sql = "SELECT ClassName,CourseName,Semester,Teacher,TeacherPhoneNumber FROM tbCourseInfo  " +
                         "WHERE tbCourseInfo.CourseName='" + CourseName + "' AND Semester='" + Semester + "' " +
                         "AND ClassName='" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Course objCourse = null;
            if (objReader.Read())
            {
                objCourse = new Course()
                {
                    ClassName = objReader["ClassName"].ToString(),
                    CourseName = objReader["CourseName"].ToString(),
                    Semester = objReader["Semester"].ToString(),
                    Teacher = objReader["Teacher"].ToString(),
                    TeacherPhoneNumber = objReader["TeacherPhoneNumber"].ToString()
                };
            }
            objReader.Close();
            return objCourse;
        }


    }
}
