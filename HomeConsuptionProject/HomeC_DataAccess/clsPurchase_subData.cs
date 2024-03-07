using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public static class clsPurchase_subData
    {
        static public bool InsertPurchase_sub( int PurchaseID,  int P_subID, int? ItemID, string ItemName, string Description, float ItemPrice, float Quantity, float TotalAmount,int? Size)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("SP_AddNewPurchase_Sub", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Size", Size != null && Size != -1 ? Size : (object)System.DBNull.Value);
                cmd.Parameters.AddWithValue("@Description", !string.IsNullOrEmpty(Description) ? Description : (object)System.DBNull.Value);


                if (ItemID != -1 && ItemID != null)
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);
                

                cmd.Parameters.AddWithValue("@ItemName", ItemName);

                cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice);
                cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                cmd.Parameters.AddWithValue("@P_subID", P_subID);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
               
                cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                try
                {
                 
                  

                    connection.Open();
                    rowAffected = cmd.ExecuteNonQuery();

                  

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }


                return (rowAffected > 0);
            }
        }

        static public bool UpdatePurchase_sub(int PurchaseID, int P_subID, int ItemID, string ItemName, string Description, float ItemPrice, float Quantity, float TotalAmount,int? Size)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Purchases_sub] 
  SET
,[ItemID] = @ItemID
,[ItemName] = @ItemName
,[Size] = @Size
,[Description] = @Description
,[ItemPrice] = @ItemPrice
,[Quantity] = @Quantity
,[TotalAmount] = @TotalAmount
WHERE PurchaseID =@PurchaseID and P_subID = @P_subID;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
            cmd.Parameters.AddWithValue("@P_subID", P_subID);
            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            cmd.Parameters.AddWithValue("@ItemName", ItemName);

            cmd.Parameters.AddWithValue("@Size", Size != null && Size != -1 ? Size : (object)System.DBNull.Value);
            cmd.Parameters.AddWithValue("@Size", !string.IsNullOrEmpty(Description) ? Description : (object)System.DBNull.Value);

            //if (Description != "" && Description != null)
            //    cmd.Parameters.AddWithValue("@Description", Description);
            //else
            //    cmd.Parameters.AddWithValue("@Description", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
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

        static public bool FindPurchase_sub(int PurchaseID, int P_subID, ref int ItemID, ref string ItemName, ref string Description, ref float ItemPrice, ref float Quantity, ref float TotalAmount, ref int? Size)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Purchases_sub] WHERE PurchaseID =@PurchaseID and P_subID = @P_subID;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);
            cmd.Parameters.AddWithValue("@P_subID", P_subID);
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; 
                    
                    ItemID = (int)reader["ItemID"];
                    ItemName = (string)reader["ItemName"];

                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];

                    else
                        Description = "";

                    Size = reader["Size"] != DBNull.Value ? (int?)reader["Size"] : null;
                    ItemPrice = Convert.ToSingle(reader[" ItemPrice"]);
                    Quantity = Convert.ToSingle(reader["Quantity"]);
                    TotalAmount = Convert.ToSingle(reader[" TotalAmount"]);
                }

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool DeletePurchase_sub(int PurchaseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Purchases_sub] WHERE PurchaseID =@PurchaseID ;";
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

        static public DataTable GetAllPurchases_sub()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Purchases_sub]";

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
         static public DataTable GetAllPurchases_subByPurchaseID(int PurchaseID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Purchases_sub] where PurchaseID =@PurchaseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PurchaseID", PurchaseID);

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

        static public DataTable GetAllPurchases_subCoulmns()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Purchases_sub] where 1=2";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                
                    dt.Load(reader);
                


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
