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

        static public bool Insert_PurchaseSubBaseCategories( int PSCategory, int PCategory)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_PurchaseSubBaseCategories", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_PSCategory", PSCategory);
                command.Parameters.AddWithValue("@p_PCategory", PCategory);



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

        static public bool Update_PurchaseSubBaseCategories(int PSCategoryID, int PCategory, int NewPSCategoryID, int NewPCategory)
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

        static public bool FindPurchase_SubCategories(int PSCategoryID,int PCategory)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[PurchaseSubBaseCategories] WHERE PSCategoryID =@PSCategoryID and PCategory =@PCategory;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
            cmd.Parameters.AddWithValue("@PCategory", PCategory);

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

            return rowsAffected >0;
        }

        static public DataTable GetAllPurchase_SubCategoriesByPCategory( int PCategory)
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


        static public bool DeletePurchaseSubBaseCategories(int PSCategoryID,int PCategory)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[PurchaseSubBaseCategories] WHERE PSCategoryID =@PSCategoryID and PCategory = @PCategory ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
            cmd.Parameters.AddWithValue("@PCategory", PCategory);
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
        static public bool DeletePurchaseSubBaseCategories( int PCategory)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[PurchaseSubBaseCategories] WHERE PSCategoryID =@PSCategoryID  ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            
            cmd.Parameters.AddWithValue("@PSCategoryID", PCategory);
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
