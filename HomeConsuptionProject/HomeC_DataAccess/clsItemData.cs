using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    static public  class clsItemData
    {
        static public void InsertItem(ref int ItemID, string ItemName_AR, string ItemName_EN, int CategoryID, float Price, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Items]
 ([ItemName_AR],[ItemName_EN],[CategoryID],[Price],[ImagePath])
 VALUES
(@ItemName_AR,@ItemName_EN,@CategoryID,@Price,@ImagePath);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ItemName_AR", ItemName_AR);
            if (ItemName_EN != "" && ItemName_EN != null)
                cmd.Parameters.AddWithValue("@ItemName_EN", ItemName_EN);
            else
                cmd.Parameters.AddWithValue("@ItemName_EN", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@Price", Price);
            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    ItemID = ID;
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
        static public bool UpdateItem(int ItemID, string ItemName_AR, string ItemName_EN, int CategoryID, float Price, string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Items] 
  SET[ItemName_AR] = @ItemName_AR
,[ItemName_EN] = @ItemName_EN
,[CategoryID] = @CategoryID
,[Price] = @Price
,[ImagePath] = @ImagePath
WHERE ItemID =@ItemID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ItemID", ItemID);
            cmd.Parameters.AddWithValue("@ItemName_AR", ItemName_AR);
            if (ItemName_EN != "" && ItemName_EN != null)
                cmd.Parameters.AddWithValue("@ItemName_EN", ItemName_EN);
            else
                cmd.Parameters.AddWithValue("@ItemName_EN", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
            cmd.Parameters.AddWithValue("@Price", Price);
            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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
        static public bool FindItem(int ItemID, ref string ItemName_AR, ref string ItemName_EN, ref int CategoryID, ref float Price, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Items] WHERE ItemID =@ItemID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ItemID", ItemID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; ItemName_AR = (string)reader["ItemName_AR"];

                    if (reader["ItemName_EN"] != DBNull.Value)
                        ItemName_EN = (string)reader["ItemName_EN"];

                    else
                        ItemName_EN = "";
                    CategoryID = (int)reader["CategoryID"];
                    Price = Convert.ToSingle(reader["Price"]);

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];

                    else
                        ImagePath = "";
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

        static public bool DeleteItem(int ItemID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE FROM [dbo].[Items] WHERE ItemID =@ItemID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ItemID", ItemID);
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


        static public DataTable GetAllItems(int PageNumber, int RowCountPerPage, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllItems", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                try
                {

                    // Create a SqlParameter object for the output parameter
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@RowCount";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)

                        {
                            dt.Load(reader);
                        }
                    }

                    RowCount = (int)outputParameter.Value;




                }

                catch (Exception ex)
                {
                    // Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {

                }
            }
            return dt;
        }

        static public DataTable GetAllItems()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT * FROM [dbo].[Items] ";

                SqlCommand command = new SqlCommand(query, connection);

               
                try
                {

                    

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)

                        {
                            dt.Load(reader);
                        }
                    }





                }

                catch (Exception ex)
                {
                    // Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {

                }
            }
            return dt;
        }



    }
}
