using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public class clsPurchase_CategoriesData
    {

        static public void Insert_Purchase_Categories(ref int PCategoryID, string CategoryName)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_Purchase_Categories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_CategoryName", CategoryName);
               

                try
                {
                    SqlParameter outputParameter = new SqlParameter();

                    outputParameter.ParameterName = "@p_PCategoryID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                    PCategoryID = (int)outputParameter.Value;



                }
                catch
                {

                }
                finally
                {

                }



            }

        }

        static public bool Update_Purchase_Categories(int PCategoryID, string CategoryName)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_update_Purchase_Categories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_CategoryName", CategoryName);
                command.Parameters.AddWithValue("@w_PCategoryID", PCategoryID);
                

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

        static public bool FindPurchase_Categories(int PCategoryID, ref string CategoryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Purchase_Categories] WHERE PCategoryID =@PCategoryID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PCategoryID", PCategoryID);
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; CategoryName = (string)reader["CategoryName"];
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

         static public bool FindPurchase_Categories(ref int PCategoryID,  string CategoryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Purchase_Categories] WHERE CategoryName =@CategoryName ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                { 
                if (reader.Read())
                    isFound = true; PCategoryID = Convert.ToInt32( reader["PCategoryID"]);
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



        static public bool DeletePurchase_Categories(int PCategoryID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE * FROM [dbo].[Purchase_Categories] WHERE PCategoryID =@PCategoryID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PCategoryID", PCategoryID);
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


        static public DataTable GetAllPurchase_Categories()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Purchase_Categories]";

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
