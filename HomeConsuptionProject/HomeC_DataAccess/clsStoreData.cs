using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    static public  class clsStoreData
    {

        static public void InsertStore(ref int StoreID, string StoreName, string Location)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Stores]
 ([StoreName],[StoreLocation])
 VALUES
(@StoreName,@StoreLocation);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@StoreName", StoreName);
            if (Location != "" && Location != null)
                cmd.Parameters.AddWithValue("@StoreLocation", Location);
            else
                cmd.Parameters.AddWithValue("@StoreLocation", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    StoreID = ID;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }

        static public bool UpdateStore(int StoreID, string StoreName, string Location)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Stores] 
  SET [StoreName] = @StoreName
,[StoreLocation] = @StoreLocation
WHERE StoreID =@StoreID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@StoreID", StoreID);
            cmd.Parameters.AddWithValue("@StoreName", StoreName);
            if (Location != "" && Location != null)
                cmd.Parameters.AddWithValue("@StoreLocation", Location);
            else
                cmd.Parameters.AddWithValue("@StoreLocation", System.DBNull.Value);

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

        static public bool FindStore(int StoreID, ref string StoreName, ref string Location)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Stores] WHERE StoreID =@StoreID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@StoreID", StoreID); 
            
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; StoreName = (string)reader["StoreName"];

                    if (reader["StoreLocation"] != DBNull.Value)
                        Location = (string)reader["StoreLocation"];

                    else
                        Location = "";
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

        static public bool DeleteStore(int StoreID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Stores] WHERE StoreID =@StoreID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@StoreID", StoreID);
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


        static public DataTable GetAllStores()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Stores]";

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

          static public DataTable GetStoreByName(string StoreName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"EXEC SP_SearchStoresByName @StoreName = @Name";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", StoreName);
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
