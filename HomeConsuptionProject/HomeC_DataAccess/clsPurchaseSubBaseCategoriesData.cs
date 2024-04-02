using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public class clsPurchaseSubBaseCategoriesData
    {

        static public bool Insert_PurchaseSubBaseCategories( int PSCategory, int PCategory, int? CreatedByUserID, int? UpdatedByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_PurchaseSubBaseCategories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_PSCategory", PSCategory);
                command.Parameters.AddWithValue("@p_PCategory", PCategory);

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
                    rowsAffected= command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                    



                }
                catch
                {

                }
                finally
                {

                }



            }
            return rowsAffected > 0;
        }

        static public bool Update_PurchaseSubBaseCategories(int PSCategoryID, int PCategory, int NewPSCategoryID, int NewPCategory, int? CreatedByUserID, int? UpdatedByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_update_PurchaseSubBaseCategories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_PSCategory", NewPSCategoryID);

                command.Parameters.AddWithValue("@p_PCategory", NewPCategory);
                command.Parameters.AddWithValue("@w_PSCategory", PSCategoryID);
                command.Parameters.AddWithValue("@w_PCategory", PCategory);
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

        static public bool FindPurchase_SubCategories(int PSCategoryID,int PCategory,ref int? CreatedByUserID, ref int? UpdatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[PurchaseSubBaseCategories] WHERE PSCategoryID =@PSCategoryID and PCategoryID =@PCategoryID;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
            cmd.Parameters.AddWithValue("@PCategoryID", PCategory);

            try
            {
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {


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

            return  isFound ;
        }

        static public DataTable GetAllPurchase_SubBaseCategoriesByPCategory( int PCategory)
        {
          DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[View_SubBaseCategoriesInfo] WHERE PCategory =@PCategory;";
            SqlCommand cmd = new SqlCommand(query, connection);

           
            cmd.Parameters.AddWithValue("@PCategory", PCategory);

            try
            {
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        dt.Load(reader);
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

            return dt;
        }

        static public DataTable GetAllPurchase_SubBaseCategoriesByPCategory(string CategoryName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[View_SubBaseCategoriesInfo] WHERE CategoryName =@CategoryName;";
            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);

            try
            {
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
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

            return dt;
        }

        static public bool DeletePurchaseSubBaseCategories(int PSCategoryID,int PCategory)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[PurchaseSubBaseCategories] WHERE PSCategoryID =@PSCategoryID and PCategoryID = @PCategoryID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
            cmd.Parameters.AddWithValue("@PCategoryID", PCategory);
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
        static public bool DeletePurchaseSubBaseCategories( int PSCategory)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[PurchaseSubBaseCategories] WHERE PSCategoryID =@PSCategoryID  ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategory);
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


    }
}
