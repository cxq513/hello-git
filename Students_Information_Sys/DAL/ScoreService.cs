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
    /// 成绩信息访问类
    /// </summary>
    public class ScoreService
    {
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
        /// 级联班级下拉框，动态填充学期下拉框
        /// </summary>
        /// <param name="SpecialityID"></param>
        /// <returns></returns>
        public DataSet GetSemesterByClassName(string ClassID)
        {
            string sql = "SELECT DISTINCT Semester FROM tbCourseInfo WHERE ClassID  = '" + ClassID + "'";
            return SQLHelper.GetDataSet(sql);
        }
        
        /// <summary>
        /// 通过班级名查找学号和学生姓名（添加用）
        /// </summary>
        /// <param name="ClassID"></param>
        /// <returns></returns>
        public List<Student> GetStudentList(string ClassID)
        {
            string sql = " SELECT StudentName, StudentNumber FROM tbStudentInfo WHERE ClassID ='" + ClassID + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Student> list = new List<Student>();
            while (objReader.Read())
            {
                list.Add(new Student()
                {
                    StudentName = objReader["StudentName"].ToString(),
                    StudentNumber = objReader["StudentNumber"].ToString()
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 判断是否录入成绩
        /// </summary>
        /// <param name="CourseName"></param>
        /// <param name="StudentNumber"></param>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public bool IsScoreExisted(string CourseName, string StudentNumber, string Semester)
        {
            string sql = "SELECT COUNT(*) FROM tbScoreInfo WHERE CourseName ='{0}' AND StudentNumber ='{1}' AND Semester ='{2}'";
            sql = string.Format(sql, CourseName, StudentNumber, Semester);
            int count = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (count == 1) return true;
            else return false;
        }

        /// <summary>
        /// 添加成绩
        /// </summary>
        /// <param name="objScore"></param>
        /// <returns></returns>
        public int AddScoer(Score objScore)
        {
            Score score = new Score();
            string sql = @"INSERT INTO [dbo].[tbScoreInfo]
                                       ([Semester]
                                       ,[StudentNumber]
                                       ,[Score_]
                                       ,[ClassName]
                                       ,[StudentNameAndNumber]
                                       ,[CourseName])
                                 VALUES
                                       ('" + objScore.Semester + @"'
                                       ,'" + objScore.StudentNumber + @"'
                                       ,'" + objScore.Score_ + @"'
                                       ,'" + objScore.ClassName + @"'
                                       ,'" + objScore.StudentNameAndNumber + @"'
                                       ,'" + objScore.CourseName + @"')";
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
        /// 查询学生成绩（浏览用）
        /// </summary>
        /// <param name="StudentNumber"></param>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public List<ScoreExt>GetStudentScore(string StudentNumber, string Semester, string ClassName)
        {
            string sql = "SELECT CourseName, Score_ FROM tbScoreInfo " +
                "WHERE StudentNumber = '" + StudentNumber + "' AND Semester = '" + Semester + "' AND ClassName = '" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<ScoreExt> list = new List<ScoreExt>();
            while (objReader.Read())
            {
                list.Add(new ScoreExt()
                {
                    CourseName = objReader["CourseName"].ToString(),
                    Score_ = Convert.ToInt32(objReader["Score_"])
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 查询班级成绩（浏览用）
        /// </summary>
        /// <param name="CourseName"></param>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public List<Score> GetClassScore(string CourseName, string Semester ,string ClassName)
        {
            string sql = "SELECT StudentNumber, Score_, StudentNameAndNumber FROM tbScoreInfo " +
                "WHERE CourseName = '" + CourseName + "' AND Semester = '" + Semester + "' AND ClassName = '" + ClassName + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Score> list = new List<Score>();
            while (objReader.Read())
            {
                list.Add(new Score()
                {
                    StudentNameAndNumber = objReader["StudentNameAndNumber"].ToString(),
                    StudentNumber = objReader["StudentNumber"].ToString(),
                    Score_ = Convert.ToInt32(objReader["Score_"])
                });
            }
            objReader.Close();
            return list;
        }

        /// <summary>
        /// 查询成绩信息（修改删除用）
        /// </summary>
        /// <param name="StudentNameAndNumber"></param>
        /// <param name="ClassName"></param>
        /// <param name="Semester"></param>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        public Score GetStudentScoreForUpdate(string StudentNameAndNumber,string ClassName, string Semester, string CourseName, string Score_)
        {
            string sql = "SELECT StudentNameAndNumber,ClassName,Semester,CourseName,Score_ FROM tbScoreInfo";
            sql += " WHERE StudentNameAndNumber='" + StudentNameAndNumber + "' AND ClassName='" + ClassName + "'" +
                "AND Semester='" + Semester + "'AND CourseName='" + CourseName + "'AND Score_='" + Score_ + "'";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Score objScore = null;
            if (objReader.Read())
            {
                objScore = new Score()
                {
                    StudentNameAndNumber = objReader["StudentNameAndNumber"].ToString(),
                    ClassName = objReader["ClassName"].ToString(),
                    Score_ = Convert.ToInt32(objReader["Score_"]),
                    CourseName = objReader["CourseName"].ToString(),
                    Semester = objReader["Semester"].ToString(),
                };
            }
            objReader.Close();
            return objScore;
        }

        /// <summary>
        /// 更新成绩信息
        /// </summary>
        /// <param name="objScore"></param>
        /// <returns></returns>
        public int UpdateScore(Score objScore)
        {
            string sql = @"UPDATE[dbo].[tbScoreInfo] 
                           SET [Score_] = '" + objScore.Score_ + @"'
                           WHERE StudentNameAndNumber='" + objScore.StudentNameAndNumber + "'" +
                           " AND ClassName='" + objScore.ClassName + "'" +
                           " AND Semester='" + objScore.Semester + "'" +
                           " AND CourseName='" + objScore.CourseName + "'";

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
        /// 删除成绩信息
        /// </summary>
        /// <param name="StudentNameAndNumber"></param>
        /// <param name="ClassName"></param>
        /// <param name="Semester"></param>
        /// <param name="CourseName"></param>
        /// <param name="Score_"></param>
        /// <returns></returns>
        public int DeleteScore(string StudentNameAndNumber, string ClassName, string Semester, string CourseName, string Score_)
        {
            string sql = "DELETE FROM tbScoreInfo WHERE StudentNameAndNumber='" + StudentNameAndNumber + "' AND ClassName='" + ClassName + "'" +
                "AND Semester='" + Semester + "'AND CourseName='" + CourseName + "'AND Score_='" + Score_ + "'";
            try
            {
                return SQLHelper.Update(sql);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("当前成绩被其他数据引用，不能直接被删除！");
                }
                else
                {
                    throw new Exception("删除成绩信息发生错误:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("删除成绩信息发生错误:" + ex.Message);
            }
        }

        /// <summary>
        /// 查询班级考试成绩综合信息
        /// </summary>
        /// <param name="ClassName"></param>
        /// <param name="Semester"></param>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        public Dictionary<string,string>GetScoreInfo(string ClassName,string Semester,string CourseName)
        {
            string sql = "SELECT countStndentNumber=COUNT(StudentNumber),avgScore_=avg(Score_),maxScore_=max(Score_),minScore_=min(Score_) " +
                "FROM tbScoreInfo WHERE ClassName='" + ClassName + "'AND Semester='" + Semester + "'" +
                "AND CourseName='" + CourseName + "';" ;
            sql += "SELECT absentCOUNT = COUNT(StudentNumber) FROM tbStudentInfo WHERE ClassName='" + ClassName + "' AND " +
                "StudentNumber NOT IN(SELECT StudentNumber FROM tbScoreInfo WHERE ClassName='" + ClassName + "'AND Semester='" + Semester + "'" +
                "AND CourseName='" + CourseName + "')";
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            Dictionary<string, string> scoreInfo = null;
            if (objReader.Read())
            {
                scoreInfo = new Dictionary<string, string>();
                scoreInfo.Add("countStndentNumber", objReader["countStndentNumber"].ToString());
                scoreInfo.Add("avgScore_", objReader["avgScore_"].ToString());
                scoreInfo.Add("maxScore_", objReader["maxScore_"].ToString());
                scoreInfo.Add("minScore_", objReader["minScore_"].ToString());
            }
            if (objReader.NextResult())
            {
                if (objReader.Read())
                {
                    scoreInfo.Add("absentCOUNT", objReader["absentCOUNT"].ToString());
                }
            }
            objReader.Close();
            return scoreInfo;
        }

        /// <summary>
        /// 查询缺考学生姓名
        /// </summary>
        /// <param name="ClassName"></param>
        /// <param name="Semester"></param>
        /// <param name="CourseName"></param>
        /// <returns></returns>
        public List<string>GetAbsentList(string ClassName, string Semester, string CourseName)
        {
            string sql= "SELECT StudentName FROM tbStudentInfo WHERE ClassName='" + ClassName + "' AND " +
                "StudentNumber NOT IN(SELECT StudentNumber FROM tbScoreInfo WHERE ClassName='" + ClassName + "'" +
                "AND Semester='" + Semester + "'AND CourseName='" + CourseName + "')";
            SqlDataReader objRader = SQLHelper.GetReader(sql);
            List<string> list = new List<string>();
            while(objRader.Read())
            {
                list.Add(objRader["StudentName"].ToString());
            }
            objRader.Close();
            return list;
        }
    }
}
