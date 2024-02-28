using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public class clsCategoriesOfPurchasesData
    {



        static public void Insert_CategoriesOfPurchases( int PCategoryID, int PurchaseID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_CategoriesOfPurchases", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_PCategoryID", PCategoryID);
                command.Parameters.AddWithValue("@p_PurchaseID", PurchaseID);


                try
                {
                    
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                  


                }
                catch
                {

                }
                finally
                {

                }



            }

        }

        static public bool Update_CategoriesOfPurchases(int PCategoryID, int PurchaseID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_update_CategoriesOfPurchases", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@w_PurchaseID", PurchaseID);
                command.Parameters.AddWithValue("@p_PCategoryID", PCategoryID);


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

        static public bool FindCategoriesOfPurchases(int PurchaseID, ref int PCategoryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[CategoriesOfPurchases] WHERE PurchaseID =@PurchaseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
            
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; 

                    PCategoryID = (int)reader["PCategoryID"];
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


        static public bool DeleteDBCategoriesOfPurchases(int PurchaseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE * FROM [dbo].[CategoriesOfPurchases] WHERE PurchaseID =@PurchaseID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);


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
