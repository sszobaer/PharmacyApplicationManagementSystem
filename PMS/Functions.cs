using System;
using System.Data;
using System.Data.SqlClient;

namespace PMS
{
    class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
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
        public DataTable GetData(string query)
        {
            dt = new DataTable();
            using (sda = new SqlDataAdapter(query, conStr))
            {
                sda.Fill(dt);
            }
            return dt;
        }

        // Method to execute a non-query (insert, update, delete) command
        public int setData(string query)
        {
            int cnt = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandText = query;
                cnt = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exception (log or display error message)
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
