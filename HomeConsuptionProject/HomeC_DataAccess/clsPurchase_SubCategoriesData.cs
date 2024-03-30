using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public class clsPurchase_SubCategoriesData
    {


        static public void Insert_Purchase_SubCategories(ref int PSCategoryID, string CategoryName, int? CreatedByUserID, int? UpdatedByUserID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_Purchase_SubCategories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_SubCategoryName", CategoryName);

                if (CreatedByUserID != -1 && CreatedByUserID != null)
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                else
                    command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                    command.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
                else
                    command.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);

                try
                {
                    SqlParameter outputParameter = new SqlParameter();

                    outputParameter.ParameterName = "@_PSCategoryID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                    PSCategoryID = (int)outputParameter.Value;



                }
                catch
                {

                }
                finally
                {

                }



            }

        }

        static public bool Update_Purchase_SubCategories(int PSCategoryID, string CategoryName, int? CreatedByUserID, int? UpdatedByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_update_Purchase_SubCategories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_SubCategoryName", CategoryName);
                
                command.Parameters.AddWithValue("@w_PSCategoryID", PSCategoryID);

                if (CreatedByUserID != -1 && CreatedByUserID != null)
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                else
                    command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                    command.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
                else
                    command.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);

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

        static public bool FindPurchase_SubCategories(int PSCategoryID, ref string SubCategoryName, ref int? CreatedByUserID, ref int? UpdatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Purchase_SubCategories] WHERE PSCategoryID =@PSCategoryID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; 
                    SubCategoryName = (string)reader["SubCategoryName"];
                    CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["CreatedByUserID"]) : null;
                    UpdatedByUserID = reader["UpdatedByUserID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["UpdatedByUserID"]) : null;

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

        static public bool FindPurchase_SubCategories(ref int PSCategoryID, string SubCategoryName, ref int? CreatedByUserID, ref int? UpdatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Purchase_SubCategories] WHERE SubCategoryName =@SubCategoryName ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SubCategoryName", SubCategoryName);

            try
            {
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        PSCategoryID = Convert.ToInt32(reader["PSCategoryID"]);
                        CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["CreatedByUserID"]) : null;
                        UpdatedByUserID = reader["UpdatedByUserID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["UpdatedByUserID"]) : null;

                    }

                }

              
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



        static public bool DeletePurchase_SubCategories(int PSCategoryID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Purchase_SubCategories] WHERE PSCategoryID =@PSCategoryID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
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
            string query = @"Select * FROM [dbo].[Purchase_SubCategories]";

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
            static public DataTable GetAllPurchase_CategoriesByPCategory(int PCategoryID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[View_SubBaseCategoriesInfo] where PCategoryID =@PCategoryID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PCategoryID", PCategoryID);
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
