using Lect25_W3_LA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.DL
{
    class AcedamicOfficerDL
    {
        DBConnection DB;

        public AcedamicOfficerDL()
        {
            DB = new DBConnection();
        }

        public DataTable GetCoursesDB()
        {
            DataTable table = new DataTable();

            try
            {
                DB.Con.Open();
                string commandstring = @"SELECT * FROM Course;";
                SqlCommand cmd = new SqlCommand(commandstring,DB.Con);
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            catch
            {

            }
            finally
            {
                DB.Con.Close();
            }
            return table;
        }

        public DataTable GetSectionsDB(string CourseID)
        {
            DataTable table = new DataTable();

            try
            {
                DB.Con.Open();
                string commandstring = @"SELECT * FROM Section WHERE CourseID = @Courseid;";
                SqlCommand cmd = new SqlCommand(commandstring, DB.Con);
                cmd.Parameters.AddWithValue("@Courseid",CourseID);
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            catch
            {

            }
            finally
            {
                DB.Con.Close();
            }
            return table;
        }
        
        public DataTable GetStudentsDB(string SectionID)
        {
            DataTable table = new DataTable();

            try
            {
                DB.Con.Open();
                string commandstring = @"SELECT * FROM Student_RegisteredCourse WHERE SecID = @Sectionid;";
                SqlCommand cmd = new SqlCommand(commandstring, DB.Con);
                cmd.Parameters.AddWithValue("@Sectionid",SectionID);
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
            }
            catch
            {

            }
            finally
            {
                DB.Con.Close();
            }
            return table;
        }

        public int AddCourseDB(CourseDTO dto)
        {

            DB.Con.Open();
            string commandstring = "INSERT INTO Course VALUES (@Courseid, @Coursename, @Credithrs, @Departmentid);";
            SqlCommand cmd = new SqlCommand(commandstring, DB.Con);
            cmd.Parameters.AddWithValue("@Courseid", dto.CourseId);
            cmd.Parameters.AddWithValue("@Coursename", dto.CourseName);
            cmd.Parameters.AddWithValue("@Credithrs", dto.CreditHrs);
            cmd.Parameters.AddWithValue("@Departmentid", dto.DepartmentId);
            int affectedrows = cmd.ExecuteNonQuery();
            DB.Con.Close();
            return affectedrows;
        }

        public int DropCourseDB(string CourseID)
        {
            DB.Con.Open();
            string commandstring1 = @"DELETE FROM Section WHERE Section.CourseID = @Courseid;";
            string commandstring2 = @"DELETE FROM Course WHERE Course.CourseID = @Courseid;";

            SqlCommand cmd1 = new SqlCommand(commandstring1, DB.Con);
            SqlCommand cmd2 = new SqlCommand(commandstring2, DB.Con);

            cmd1.Parameters.AddWithValue("@Courseid", CourseID);
            cmd2.Parameters.AddWithValue("@Courseid", CourseID);

            int affectedrows1 = cmd1.ExecuteNonQuery();
            int affectedrows2 = cmd2.ExecuteNonQuery();
            DB.Con.Close();
            return affectedrows2;
        }

        public int AddSectionDB(SectionDTO dto)
        {

            DB.Con.Open();
            string commandstring = "INSERT INTO Section VALUES (@Sectionid, @Courseid, @Sectionname, @Facultyid, @Capacity, @Strength, @Status);";
            SqlCommand cmd = new SqlCommand(commandstring, DB.Con);
            cmd.Parameters.AddWithValue("@Sectionid", dto.SectionId);
            cmd.Parameters.AddWithValue("@Courseid", dto.CourseId);
            cmd.Parameters.AddWithValue("@Sectionname", dto.SectionName);
            cmd.Parameters.AddWithValue("@Facultyid", dto.FacultyId);
            cmd.Parameters.AddWithValue("@Capacity", dto.Capacity);
            cmd.Parameters.AddWithValue("@Strength", dto.Strength);
            cmd.Parameters.AddWithValue("@Status", dto.Status);
            int affectedrows = cmd.ExecuteNonQuery();
            DB.Con.Close();
            return affectedrows;
        }
        
        public int DropSectionDB(string SectionID)
        {

            DB.Con.Open();
            string commandstring1 = "DELETE FROM AddDropRequest WHERE AddDropRequest.SecID = @Sectionid;";
            string commandstring2 = "DELETE FROM Student_RegisteredCourse WHERE Student_RegisteredCourse.SecID =@Sectionid;";
            string commandstring3 = "DELETE FROM Section WHERE Section.SecID =@Sectionid;";

            SqlCommand cmd1 = new SqlCommand(commandstring1, DB.Con);
            cmd1.Parameters.AddWithValue("@Sectionid", SectionID);

            SqlCommand cmd2 = new SqlCommand(commandstring2, DB.Con);
            cmd2.Parameters.AddWithValue("@Sectionid", SectionID);

            SqlCommand cmd3 = new SqlCommand(commandstring3, DB.Con);
            cmd3.Parameters.AddWithValue("@Sectionid",SectionID);
           
            int affectedrows1 = cmd1.ExecuteNonQuery();
            int affectedrows2 = cmd2.ExecuteNonQuery();
            int affectedrows3 = cmd3.ExecuteNonQuery();
            DB.Con.Close();
            return affectedrows3;
        }



        public int ChangeCapacityDB(string Capacity, string SectionID)
        {
            DB.Con.Open();

            string commandstring = "UPDATE Section SET Section.Capacity=@Capacity WHERE Section.SecID=@Sectionid;";

            SqlCommand cmd = new SqlCommand(commandstring, DB.Con);
            cmd.Parameters.AddWithValue("@Sectionid", SectionID);
            cmd.Parameters.AddWithValue("@Capacity", Capacity);

            int affectedrows = cmd.ExecuteNonQuery();
            DB.Con.Close();
            return affectedrows;
        }
    }
}
