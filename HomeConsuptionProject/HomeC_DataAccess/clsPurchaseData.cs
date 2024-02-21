using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
   static public  class clsPurchaseData
    {

        static public void InsertPurchase(ref int PurchaseID, DateTime IssueDate, float TotalBefore,float TaxAmount, float TotalAfterTax, int StoreID,int Type,float? Discount)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_AddNewPurchase", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@TotalBeforTax", TotalBefore);
                    command.Parameters.AddWithValue("@TaxAmount", TaxAmount);
                    command.Parameters.AddWithValue("@TotalAfterTax", TotalAfterTax);
                    command.Parameters.AddWithValue("@StoreID", StoreID);
                    command.Parameters.AddWithValue("@Type", Type);

                if(Discount != -1 && Discount !=null)
                    command.Parameters.AddWithValue("@Discount", Discount);
                else
                    command.Parameters.AddWithValue("@Discount", DBNull.Value);

                try
                {
                    SqlParameter outputParameter = new SqlParameter();

                    outputParameter.ParameterName = "@PurchaseID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                     PurchaseID = (int)outputParameter.Value;



                }
                    catch
                    {

                    }
                    finally
                    {

                   }
                

               
            }

        }


        static public bool UpdatePurchase(int PurchaseID, DateTime IssueDate, float TotalBeforTax, float TaxAmount, float TotalAfterTax, int StoreID,int Type, float? Discount)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdatePurchase", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@TotalBeforTax", TotalBeforTax);
                command.Parameters.AddWithValue("@TaxAmount", TaxAmount);
                command.Parameters.AddWithValue("@TotalAfterTax", TotalAfterTax);
                command.Parameters.AddWithValue("@StoreID", StoreID);
                command.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                command.Parameters.AddWithValue("@Type", Type);


                if (Discount != -1 && Discount != null)
                    command.Parameters.AddWithValue("@Discount", Discount);
                else
                    command.Parameters.AddWithValue("@Discount", DBNull.Value);

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

        static public bool FindPurchase( int PurchaseID, ref DateTime IssueDate, ref float TotalBeforTax, ref float TaxAmount, ref float TotalAfterTax,
            ref int StoreID, ref int Type, ref float? Discount)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_GetPurchaseByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PurchaseID", PurchaseID);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            IssueDate = Convert.ToDateTime( reader["IssueDate"]);
                            TotalAfterTax = Convert.ToSingle( reader["TotalAfterTax"]);
                            TaxAmount = Convert.ToSingle( reader["TaxAmount"]);
                            StoreID = Convert.ToInt32( reader["StoreID"]);
                            Type = Convert.ToInt32( reader["Type"]);
                            TotalBeforTax = Convert.ToSingle( reader["TotalBeforTax"]);


                            if (reader["Discount"] != DBNull.Value)
                                Discount = Convert.ToSingle(reader["Discount"]);

                            else
                                Discount = null;



                        }

                    }
                }
                catch
                {
                    isFound = false;
                }
               
            }
              
        return isFound;
        }
        
           
                   
        


        static public bool DeletePurchase(int PurchaseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE * FROM [dbo].[Purchases] WHERE PurchaseID =@PurchaseID ;";
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



        static public DataTable GetAllPurchases(int PageNumber,int RowCountPerPage,ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchase", connection);

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

                    RowCount =(int)outputParameter.Value;




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

        static public DataTable GetAllPurchasesInfoWithPages(int PageNumber, int RowCountPerPage, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPaging", connection);

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


        static public DataTable GetPurchasesInfo(string ColumnName, string Value)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM View_PurchasesInfo  where " + ColumnName + " LIKE  '" + Value + "%'";

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


        static public DataTable GetPurchaseColumns()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[Purchases] where 1=2";

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
