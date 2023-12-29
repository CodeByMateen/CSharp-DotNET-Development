using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lect25_W3_LA.DTO;

namespace Lect25_W3_LA.DL
{
    class StudentDL
    {
        private DBConnection dbCon;
        public StudentDL()
        {
            dbCon = new DBConnection();
        }
        public DataTable GetOfferedCoursesFromDB(string userID)
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string queryString = "SELECT Course.CourseID, Section.SecID, Course.CourseName , Section.SecName , Course.CreditHrs , Section.Strength , Faculty.FacName FROM Course, Section, Faculty WHERE Course.CourseID = Section.CourseID AND Section.FacID = Faculty.FacID AND Section.SecID NOT IN (SELECT Student_RegisteredCourse.SecID FROM Student_RegisteredCourse WHERE Student_RegisteredCourse.StdID = @StdID); ";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@StdID", userID);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }catch(SqlException ex)
            {
                throw ex;
            }finally
            {
                dbCon.Con.Close();
            }
            
        }

        public void DropCourseRequestInDB(RequestDTO reqDTO)
        {
            try
            {
                dbCon.Con.Open();
                //( SELECT FacID FROM Student_Advisor WHERE StdID=@StdID)
                string queryString = "INSERT INTO AddDropRequest (StdID, SecID,ReqType, FacID) SELECT @StdID, @SecID,@ReqType,(SELECT FacID FROM Student_Advisor WHERE StdID=@StdID);";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@SecID", reqDTO.SecID);
                com.Parameters.AddWithValue("@StdID", reqDTO.StdID);
                com.Parameters.AddWithValue("@ReqType", reqDTO.ReqType);
                int rowAffected = com.ExecuteNonQuery();

                string queryString2 = "UPDATE Student_RegisteredCourse SET Status = 'drop course' WHERE StdID = @StdID AND SecID = @SecID;";
                com.CommandText = queryString2;
                int rowsAff = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }

        }

        public void RegisterCourseRequestInDB(RequestDTO reqDTO)
        {
            try
            {
                dbCon.Con.Open();
                //( SELECT FacID FROM Student_Advisor WHERE StdID=@StdID)
                string queryString = "INSERT INTO AddDropRequest (StdID, SecID,ReqType, FacID) SELECT @StdID, @SecID,@ReqType,(SELECT FacID FROM Student_Advisor WHERE StdID=@StdID);";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@SecID", reqDTO.SecID);
                com.Parameters.AddWithValue("@StdID", reqDTO.StdID);
                com.Parameters.AddWithValue("@ReqType", reqDTO.ReqType);
                int rowAffected = com.ExecuteNonQuery();

                string queryString2 = "INSERT INTO Student_RegisteredCourse VALUES(@StdID, @SecID,'add request');";
                com.CommandText = queryString2;
                int rowsAff = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }

        }
        /*
        public void DropCourseInDB(CourseRegisterDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();

                string queryString = "Delete FROM Student_RegisteredCourse WHERE StdID= @StdID AND SecID =  @SecID;";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@SecID", crDTO.SecID);
                com.Parameters.AddWithValue("@StdID", crDTO.StdID);
                int rowAffected = com.ExecuteNonQuery();

                string updateQuery = "Update Section SET Strength= Strength-1 WHERE SecID=@SecID";
                com.CommandText = updateQuery;
                rowAffected = com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }
        */
        public DataTable GetRegisterCoursesFromDB(string userID)
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string queryString = "SELECT Course.CourseID, Section.SecID, Course.CourseName , Section.SecName , Course.CreditHrs , Section.Strength , Faculty.FacName FROM Course, Section, Faculty WHERE Course.CourseID = Section.CourseID AND Section.FacID = Faculty.FacID AND Section.SecID IN (SELECT Student_RegisteredCourse.SecID FROM Student_RegisteredCourse WHERE Student_RegisteredCourse.StdID = @StdID AND Status='registered'); ";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@StdID", userID);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
            
        }
        /*
        public void RegisterCourseInDB(CourseRegisterDTO crDTO)
        {
            try
            {
                dbCon.Con.Open();

                string queryString = "INSERT INTO Student_RegisteredCourse VALUES(@StdID, @SecID);";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@SecID", crDTO.SecID);
                com.Parameters.AddWithValue("@StdID", crDTO.StdID);
                int rowAffected = com.ExecuteNonQuery();

                string updateQuery = "Update Section SET Strength= Strength+1 WHERE SecID=@SecID";
                //com.Parameters.AddWithValue("@SecID", crDTO.SecID);
                com.CommandText = updateQuery;
                rowAffected = com.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbCon.Con.Close();
            }
        }
        */
  
    }
}
