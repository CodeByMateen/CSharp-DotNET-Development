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
    class FacultyDL
    {
        private DBConnection dbCon;
        public FacultyDL()
        {
            dbCon = new DBConnection();
        }

        public DataTable GetPendingRequestsFromDB(UserDTO facultyDTO)
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string queryString = "SELECT AddDropRequest.Status, AddDropRequest.ReqID , AddDropRequest.StdID, AddDropRequest.SecID, Student.StdName , Course.CourseName,Section.SecName,AddDropRequest.ReqType, AddDropRequest.DateGenerated FROM    AddDropRequest , Course , Section, Student WHERE   AddDropRequest.StdID = Student.StdID AND Course.CourseID = Section.CourseID AND AddDropRequest.SecID = Section.SecID AND AddDropRequest.Status = 'pending' AND AddDropRequest.FacID=@FacID; ";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@FacID", facultyDTO.UserID);
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

        public void UpdatePendingRequestsInDB(List<RequestDTO> updatedRequests)
        {
            try
            {
                dbCon.Con.Open();
                foreach(RequestDTO dto in updatedRequests)
                {
                    string queryString = "Update AddDropRequest SET Status=@status WHERE ReqID = @ReqID";
                    SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                    com.Parameters.AddWithValue("@status", dto.ReqStatus);
                    com.Parameters.AddWithValue("@ReqID", dto.ReqID);
              
                    int val  =com.ExecuteNonQuery();

                    if(dto.ReqType=="add")
                    {
                        string queryString2 = "UPDATE Student_RegisteredCourse SET Status='registered' WHERE StdID = @StdID AND SecID = @SecID";

                        com.Parameters.AddWithValue("@StdID", dto.StdID);
                        com.Parameters.AddWithValue("@SecID", dto.SecID);

                        com.CommandText = queryString2;
                     
                        int rowsAff = com.ExecuteNonQuery();

                        string updateQuery = "Update Section SET Strength= Strength+1 WHERE SecID=@SecID";
                        com.CommandText = updateQuery;
                        rowsAff = com.ExecuteNonQuery();

                    }
                    else if(dto.ReqType =="drop")
                    {
                        string queryDel = "Delete FROM Student_RegisteredCourse WHERE StdID= @StdID AND SecID =  @SecID;";
                        com.Parameters.AddWithValue("@StdID", dto.StdID);
                        com.Parameters.AddWithValue("@SecID", dto.SecID);

                        com.CommandText = queryDel;

                        int rowAffected = com.ExecuteNonQuery();

                        string updateQuery = "Update Section SET Strength= Strength-1 WHERE SecID=@SecID";
                        com.CommandText = updateQuery;
                        rowAffected = com.ExecuteNonQuery();
                    }
                }
                
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
    }


}
