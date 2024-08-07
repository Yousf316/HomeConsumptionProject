using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
   public class clsSizesData
    {

        static public void InsertSize(ref int SizeID, string SizeName, int? CreatedByUserID, int? UpdatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO [dbo].[Sizes]
 ([SizeName])
 VALUES
(@SizeName);
Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SizeName", SizeName);

            if (CreatedByUserID != -1 && CreatedByUserID != null)
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            else
                cmd.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

            if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                cmd.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
            else
                cmd.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    SizeID = ID;
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



        static public bool UpdateSize(int SizeID, string SizeName, int? CreatedByUserID, int? UpdatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE [dbo].[Sizes] 
  SET[SizeName] = @SizeName
WHERE SizeID =@SizeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SizeID", SizeID);
            cmd.Parameters.AddWithValue("@SizeName", SizeName);

            if (CreatedByUserID != -1 && CreatedByUserID != null)
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            else
                cmd.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

            if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                cmd.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
            else
                cmd.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);


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

        static public bool FindSize(int SizeID, ref string SizeName, ref int? CreatedByUserID, ref int? UpdatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Sizes] WHERE SizeID =@SizeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SizeID", SizeID); try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; SizeName = (string)reader["SizeName"];
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


        static public bool DeleteSize(int SizeID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[Sizes] WHERE SizeID =@SizeID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@SizeID", SizeID);
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



        static public DataTable GetAllSizesInfoWithPages(int PageNumber, int RowCountPerPage, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllSizesInfoWithPaging", connection);

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



        static public DataTable GetAllSizes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Sizes]";

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
