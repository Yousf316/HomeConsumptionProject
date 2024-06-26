﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_DataAccess
{
    public class clsPersonData
    {
        static public void Insert_Person(ref int PersonID, string FirstName, string SecondName, string ThirdName, 
            string LastName, string PhoneNumber, string Email, int NationalityCountryID,int? CreatedByUserID,int? UpdatedByUserID)

        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_insert_People", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_FirstName", FirstName);
                command.Parameters.AddWithValue("@p_SecondName", SecondName);
                command.Parameters.AddWithValue("@p_ThirdName", ThirdName);
                command.Parameters.AddWithValue("@p_LastName", LastName);
                command.Parameters.AddWithValue("@p_PhoneNumber", PhoneNumber);
                
                command.Parameters.AddWithValue("@p_NationalityCountryID", NationalityCountryID);

                if (CreatedByUserID != -1 && CreatedByUserID != null)
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                else
                    command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                if (Email != "")
                    command.Parameters.AddWithValue("@p_Email", Email);
                else
                    command.Parameters.AddWithValue("@p_Email", DBNull.Value);

                if (UpdatedByUserID != -1 && UpdatedByUserID != null)
                    command.Parameters.AddWithValue("@UpdatedByUserID", UpdatedByUserID);
                else
                    command.Parameters.AddWithValue("@UpdatedByUserID", DBNull.Value);

                try
                {
                    SqlParameter outputParameter = new SqlParameter();

                    outputParameter.ParameterName = "@PersonID";
                    outputParameter.SqlDbType = SqlDbType.Int;
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Retrieve the value of the output parameter
                    PersonID = (int)outputParameter.Value;



                }
                catch
                {

                }
                finally
                {

                }
            }
        }
        static public bool Update_Person(int PersonID, string FirstName, string SecondName, 
            string ThirdName, string LastName, string PhoneNumber,
            string Email, int NationalityCountryID, int? CreatedByUserID, int? UpdatedByUserID)

        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand("sp_update_People", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@w_PersonID", PersonID);
                command.Parameters.AddWithValue("@p_FirstName", FirstName);
                command.Parameters.AddWithValue("@p_SecondName", SecondName);
                command.Parameters.AddWithValue("@p_ThirdName", ThirdName);
                command.Parameters.AddWithValue("@p_LastName", LastName);
                command.Parameters.AddWithValue("@p_PhoneNumber", PhoneNumber);
                command.Parameters.AddWithValue("@p_NationalityCountryID", NationalityCountryID);

                if (CreatedByUserID != -1 && CreatedByUserID != null)
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                else
                    command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                if (Email != "")
                    command.Parameters.AddWithValue("@p_Email", Email);
                else
                    command.Parameters.AddWithValue("@p_Email", DBNull.Value);

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

        static public bool FindPerson(int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName,
            ref string PhoneNumber, ref string Email, ref int NationalityCountryID, ref int? CreatedByUserID,ref int? UpdatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM [dbo].[People] WHERE PersonID =@PersonID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true; FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    if (reader["LastName"] != DBNull.Value)
                        LastName = (string)reader["LastName"];

                    else
                        LastName = "";

                    if (reader["PhoneNumber"] != DBNull.Value)
                        PhoneNumber = (string)reader["PhoneNumber"];

                    else
                        PhoneNumber = "";

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    else
                        Email = "";

                    if (reader["CreatedByUserID"] != DBNull.Value)
                        CreatedByUserID = (int)reader["CreatedByUserID"];

                   

                    if (reader["UpdatedByUserID"] != DBNull.Value)
                        UpdatedByUserID = (int)reader["UpdatedByUserID"];

                   
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


        static public bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"DELETE  FROM [dbo].[People] WHERE PersonID =@PersonID ;";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
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

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * FROM [dbo].[People]";

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

        static public bool IsPersonExsits(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select top(1) X =1 FROM People  where PersonID = @PersonID";
            
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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
