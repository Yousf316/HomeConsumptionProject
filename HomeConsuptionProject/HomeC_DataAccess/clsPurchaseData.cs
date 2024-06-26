﻿using System;

using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace HomeC_DataAccess
{
    static public class clsPurchaseData
    {

        static public void InsertPurchase(ref int PurchaseID, DateTime IssueDate, float TotalBefore, float TaxAmount,
            float TotalAfterTax, int StoreID, int Type, float? Discount, int PCategoryID, int? PSCategoryID,int? CreatedByUserID, int? UpdatedByUserID)
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
                command.Parameters.AddWithValue("@PCategoryID", PCategoryID);

                if (CreatedByUserID != -1 && CreatedByUserID != null)
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                else
                    command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                    command.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
                else
                    command.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);

                if (Discount != -1 && Discount != null)
                    command.Parameters.AddWithValue("@Discount", Discount);
                else
                    command.Parameters.AddWithValue("@Discount", DBNull.Value);


                if (PSCategoryID != -1 && PSCategoryID != null)
                    command.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
                else
                    command.Parameters.AddWithValue("@PSCategoryID", DBNull.Value);

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


        static public bool UpdatePurchase(int PurchaseID, DateTime IssueDate, float TotalBeforTax,
            float TaxAmount, float TotalAfterTax, int StoreID, int Type, float? Discount, int PCategoryID, int? PSCategoryID, int? CreatedByUserID, int? UpdatedByUserID)
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
                command.Parameters.AddWithValue("@PCategoryID", PCategoryID);

                if (CreatedByUserID != -1 && CreatedByUserID != null)
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                else
                    command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                    command.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
                else
                    command.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);

                if (Discount != -1 && Discount != null)
                    command.Parameters.AddWithValue("@Discount", Discount);
                else
                    command.Parameters.AddWithValue("@Discount", DBNull.Value);

                if (PSCategoryID != -1 && PSCategoryID != null)
                    command.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);
                else
                    command.Parameters.AddWithValue("@PSCategoryID", DBNull.Value);

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

        static public bool FindPurchase(int PurchaseID, ref DateTime IssueDate, ref float TotalBeforTax, ref float TaxAmount, ref float TotalAfterTax,
            ref int StoreID, ref int Type, ref float? Discount, ref int PCategoryID, ref int? PSCategoryID, ref int? CreatedByUserID, ref int? UpdatedByUserID)
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
                            IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                            TotalAfterTax = Convert.ToSingle(reader["TotalAfterTax"]);
                            TaxAmount = Convert.ToSingle(reader["TaxAmount"]);
                            StoreID = Convert.ToInt32(reader["StoreID"]);
                            Type = Convert.ToInt32(reader["Type"]);
                            TotalBeforTax = Convert.ToSingle(reader["TotalBeforTax"]);
                            PCategoryID = Convert.ToInt32(reader["PCategoryID"]);


                            if (reader["Discount"] != DBNull.Value)
                                Discount = Convert.ToSingle(reader["Discount"]);

                            else
                                Discount = null;

                            PSCategoryID = reader["PSCategoryID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["PSCategoryID"]) : null;
                            CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["CreatedByUserID"]) : null;
                            UpdatedByUserID = reader["UpdatedByUserID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["UpdatedByUserID"]) : null;

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
            string query = @"DELETE  FROM [dbo].[Purchases] WHERE PurchaseID =@PurchaseID ;";
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



        static public DataTable GetAllPurchases(int PageNumber, int RowCountPerPage, ref int RowCount)
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

        static public DataTable GetAllPurchaseID()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"select PurchaseID from Purchases";
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


        static public DataTable GetAllPurchases()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"select * from Purchases";
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

        static public DataTable GetAllPurchasesByType(string type)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"select * from View_PurchasesInfo where TypeName =@type";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@type", type);



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

        static public DataTable GetAllPurchasesInfoWithPagesByStoreName(int PageNumber, int RowCountPerPage, string StoreName, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByStoreName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@StoreName", StoreName);
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

        static public DataTable GetAllPurchasesInfoWithPagesByTypeName(int PageNumber, int RowCountPerPage, string TypeName, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByTypeName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@TypeName", TypeName);
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

        static public DataTable SP_GetAllPurchaseInfoWithPagingByTotalAfterTax(int PageNumber, int RowCountPerPage, float TotalAfterTax, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByTotalAfterTax", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@TotalAfterTax", TotalAfterTax);
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

        static public DataTable GetAllPurchasesInfoWithPagesByDate(int PageNumber, int RowCountPerPage, DateTime DateFrom, DateTime DateTo, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByDate", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
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

                    RowCount = outputParameter.Value != DBNull.Value ? (int)outputParameter.Value : 0;




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

        static public DataTable GetAllPurchasesInfoWithPagesByDateOfStoreName(int PageNumber, int RowCountPerPage, DateTime DateFrom, DateTime DateTo, string StoreName, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByDateofStoreName", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
                command.Parameters.AddWithValue("@StoreName", StoreName);
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

                    RowCount = outputParameter.Value != DBNull.Value ? (int)outputParameter.Value : 0;




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


        static public DataTable GetAllPurchaseInfoWithPagingByDateofTotalAfterTax(int PageNumber, int RowCountPerPage, DateTime DateFrom, DateTime DateTo, float TotalAfterTax, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByDateofTotalAfterTax", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
                command.Parameters.AddWithValue("@TotalAfterTax", TotalAfterTax);
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

                    RowCount = outputParameter.Value != DBNull.Value ? (int)outputParameter.Value : 0;




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

        static public DataTable GetAllPurchaseInfoWithPagingByDateofType(int PageNumber, int RowCountPerPage, DateTime DateFrom, DateTime DateTo, string TypeName, ref int RowCount)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAllPurchaseInfoWithPagingByDateofType", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowCountPerPage", RowCountPerPage);
                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
                command.Parameters.AddWithValue("@TypeName", TypeName);
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

                    RowCount = outputParameter.Value != DBNull.Value ? (int)outputParameter.Value : 0;




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

        static public DataTable GetPurchasesInfo(int PurchaseID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM View_PurchasesInfo  where PurchaseID =  @PurchaseID";

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

        static public DataTable GetPurchasesInfoByID(int PurchaseID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM View_PurchasesInfo  where PurchaseID = @PurchaseID";

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


        static public float GetTotalAllPurchases()
        {
            float Total = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand("SP_GetAlltotalPurchase", connection);

                command.CommandType = CommandType.StoredProcedure;


                try
                {

                    // Create a SqlParameter object for the output parameter
                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.ParameterName = "@TotalAfterTax";
                    outputParameter.SqlDbType = SqlDbType.SmallMoney;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();

                    command.ExecuteNonQuery();


                    Total = Convert.ToSingle(outputParameter.Value);




                }

                catch (Exception ex)
                {
                    // Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {

                }
            }
            return Total;
        }


        static public float GetTotalPurchasesByCategoryName(string CategoryName, string DateFrom, string DateTo)
        {
            float Total = 0;

            string query = @"SELECT sum(TotalAfterTax) as Total
  FROM [dbo].[View_PurchasesInfo]
  where CategoryName = @CategoryName and IssueDate between @DateFrom and  @DateTo ";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);



                command.Parameters.AddWithValue("@CategoryName", CategoryName);
                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
                try
                {

                    // Create a SqlParameter object for the output parameter

                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && float.TryParse(result.ToString(), out float _Total))
                    {
                        Total = _Total;
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
            return Total;
        }
        static public float GetTotalPurchasesByCategoryName(string CategoryName)
        {
            float Total = 0;

            string query = @"SELECT sum(TotalAfterTax) as Total
  FROM [dbo].[View_PurchasesInfo]
  where CategoryName = @CategoryName ";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);



                command.Parameters.AddWithValue("@CategoryName", CategoryName);

                try
                {

                    // Create a SqlParameter object for the output parameter

                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && float.TryParse(result.ToString(), out float _Total))
                    {
                        Total = _Total;
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
            return Total;
        }

        static public float GetTotalPurchasesBySubCategoryName(string CategoryName,string SubCategoryName, string DateFrom, string DateTo)
        {
            float Total = 0;

            string query = @"SELECT sum(TotalAfterTax) as Total
  FROM [dbo].[View_PurchasesInfo]
  where CategoryName = @CategoryName and SubCategoryName = @SubCategoryName and IssueDate between @DateFrom and  @DateTo ";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);



                command.Parameters.AddWithValue("@CategoryName", CategoryName);
                command.Parameters.AddWithValue("@SubCategoryName", SubCategoryName);
                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
                try
                {

                    // Create a SqlParameter object for the output parameter

                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && float.TryParse(result.ToString(), out float _Total))
                    {
                        Total = _Total;
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
            return Total;
        }
        static public float GetTotalPurchasesBySubCategoryName(string CategoryName, string SubCategoryName)
        {
            float Total = 0;

            string query = @"SELECT sum(TotalAfterTax) as Total
  FROM [dbo].[View_PurchasesInfo]
  where CategoryName = @CategoryName and SubCategoryName = @SubCategoryName ";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);



                command.Parameters.AddWithValue("@CategoryName", CategoryName);
                command.Parameters.AddWithValue("@SubCategoryName", SubCategoryName);

                try
                {

                    // Create a SqlParameter object for the output parameter

                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && float.TryParse(result.ToString(), out float _Total))
                    {
                        Total = _Total;
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
            return Total;
        }

        static public float GetTotalPurchasesByDate(string DateFrom, string DateTo)
        {
            float Total = 0;

            string query = @"SELECT sum(TotalAfterTax) as Total
  FROM [dbo].[View_PurchasesInfo]
  where  IssueDate between @DateFrom and  @DateTo ";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);




                command.Parameters.AddWithValue("@DateFrom", DateFrom);
                command.Parameters.AddWithValue("@DateTo", DateTo);
                try
                {

                    // Create a SqlParameter object for the output parameter

                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && float.TryParse(result.ToString(), out float _Total))
                    {
                        Total = _Total;
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
            return Total;
        }




        static public bool IsPurchseExsits(int PCategoryID,int PSCategoryID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select top(1) X =1 FROM Purchases  where PCategoryID = @PCategoryID and PSCategoryID = @PSCategoryID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PCategoryID", PCategoryID);
            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);

            try
            {
                connection.Open();

               object reader = cmd.ExecuteScalar();

                if (reader != null)

                {
             IsFound = true;

                }

                


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public bool IsPurchseExsits(int PSCategoryID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select top(1) X =1 FROM Purchases  where PSCategoryID = @PSCategoryID";

            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.AddWithValue("@PSCategoryID", PSCategoryID);

            try
            {
                connection.Open();

                object reader = cmd.ExecuteScalar();

                if (reader != null)

                {
                    IsFound = true;

                }




            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public bool IsPurchseExsitsByPCategory(int PCategoryID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select top(1) X =1 FROM Purchases  where PCategoryID = @PCategoryID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PCategoryID", PCategoryID);

            try
            {
                connection.Open();

                object reader = cmd.ExecuteScalar();

                if (reader != null)

                {
                    IsFound = true;

                }




            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }


    }
}
