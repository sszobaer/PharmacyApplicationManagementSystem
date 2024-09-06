using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PMS
{
    class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter sda;
        private DataTable dt;
        private string conStr;

        public Functions()
        {
            conStr = @"Data Source=ZOBAER;Initial Catalog=""Pharmacy Management System"";Persist Security Info=True;User ID=sa;Password=admin;Encrypt=True;TrustServerCertificate=True";
            con = new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        // Method to get data from the database
        public DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dt; // Always return a DataTable (empty if an error occurred)
        }



        //Execute a non-query (insert, update, delete) command
        public int setData(string query, Dictionary<string, object> parameters = null)
        {
            int cnt = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Clear previous parameters
                    cmd.Parameters.Clear();

                    // Add new parameters
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            // Use Add with parameter type if needed
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    cnt = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return cnt;
        }

    }
}
