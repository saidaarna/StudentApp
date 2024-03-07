using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DBL
{
    internal class DBHelper
    {
        string constring = "";

        public void ExecuteNonQuery(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(constring);
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error: " + ex.Message);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }


        public DataTable ExecuteReader(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(constring);
            try
            {
                sqlConnection.Open();
                SqlDataAdapter Sda = new SqlDataAdapter(sql, sqlConnection);
                Sda.Fill(dt);
            }
            catch (SqlException ex)
            {

                Console.WriteLine("SQL Error: " + ex.Message);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return dt;
        }
    }
}

