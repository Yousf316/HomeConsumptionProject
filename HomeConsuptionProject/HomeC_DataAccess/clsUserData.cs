using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public class clsUserData
    {
        static public void InsertUser(ref int UserID, int PersonID, string Password, bool IsActive)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_Users", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_PersonID", PersonID);
                command.Parameters.AddWithValue("@p_Password", Password);
                command.Parameters.AddWithValue("@p_IsActive", IsActive);



                try
                {
                    SqlParameter outputParameter = new SqlParameter();

                    outputParameter.ParameterName = "@UserID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                    UserID = (int)outputParameter.Value;



                }
                catch
                {

                }
                finally
                {

                }
            }
        }
        static public bool UpdateUser(int UserID, int PersonID, string Password, bool IsActive)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_update_Users", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_PersonID", PersonID);
                command.Parameters.AddWithValue("@p_Password", Password);
                command.Parameters.AddWithValue("@p_IsActive", IsActive);
                command.Parameters.AddWithValue("@w_UserID", UserID);
                try
                {




                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter




                }
                catch
                {

                }
                finally
                {

                }



            }

            return (rowsAffected > 0);
        }
        static public bool FindUser(int UserID, ref int PersonID, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Users] WHERE UserID =@UserID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        static public bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Users] WHERE UserID =@UserID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();

                rowsAffected = cmd.ExecuteNonQuery();


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Users]";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
