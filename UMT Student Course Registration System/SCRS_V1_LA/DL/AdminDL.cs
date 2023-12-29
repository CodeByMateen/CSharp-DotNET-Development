using Lect25_W3_LA.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect25_W3_LA.DL
{
    class AdminDL
    {
        private DBConnection dbCon;
        public AdminDL()
        {
            dbCon = new DBConnection();
        }
        public void CreateAccountInDB(UserDTO ud)
        {
            try
            {
                dbCon.Con.Open();
                //string queryString = "INSERT INTO MyUser VALUES('"+ud.UserID+"','"+ud.Password+"','"+ud.Role+"','active');" ;
                string queryString1 = "INSERT INTO MyUser VALUES(@UserID, @Password , @Role, 'active',@Name);";

                SqlCommand com = new SqlCommand(queryString1, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", ud.UserID);
                com.Parameters.AddWithValue("@Password", ud.Password);
                com.Parameters.AddWithValue("@Role", ud.Role);
                com.Parameters.AddWithValue("@Name", ud.Name);

                int rowAffected = com.ExecuteNonQuery();
            }catch(SqlException ex)
            {
                throw ex;
            }finally
            {
                dbCon.Con.Close();
            }
        }

        public void Block_UnBlock_User_InDB(UserDTO uDTO)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "UPDATE MyUser SET Status = @newStatus WHERE UserID = @UserID;";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", uDTO.UserID);
                com.Parameters.AddWithValue("@newStatus", uDTO.Status);

                int noOfRowsAffected = com.ExecuteNonQuery();

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
        internal UserDTO CheckAccount(string text)
        {
            UserDTO retDTO = new UserDTO();
            try
            {
                dbCon.Con.Open();
                string queryString = "SELECT * FROM MyUser WHERE UserID = @UserID;";

                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", text);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDTO.UserID = reader["UserID"].ToString();
                    retDTO.Role = reader["Role"].ToString();
                    retDTO.Status = reader["Status"].ToString();
                    retDTO.Name = reader["Name"].ToString();
                    return retDTO;
                }
                return null;
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
            internal void AddFacultyInDB(UserDTO ud)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "INSERT INTO Faculty VALUES(@UserID,@Name);";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", ud.UserID);
                com.Parameters.AddWithValue("@Password", ud.Name);

                int rowAffected = com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dbCon.Con.Close();
            }
        }

        internal void AddStudentInDB(UserDTO ud)
        {
            try
            {
                dbCon.Con.Open();
                string queryString = "INSERT INTO Student VALUES(@UserID,@Name);";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@UserID", ud.UserID);
                com.Parameters.AddWithValue("@Password", ud.Name);
                int rowAffected = com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dbCon.Con.Close();
            }
        }
    }
}












