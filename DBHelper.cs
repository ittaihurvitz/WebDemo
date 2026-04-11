
using System;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Class DBHelper helps with Database actions
/// </summary>
/// 

namespace IttaiWebDemo
{
    public class DBHelper
    {
        // Connects to the database and returns the connection object
        public static SqlConnection ConnectToDb(string fileName)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\" + fileName + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        // Executes a non-query SQL command (like INSERT, UPDATE, DELETE)
        public static int DoNonQuery(string fileName, string sql)
        {
            int rowsAffected = 0;
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            rowsAffected = com.ExecuteNonQuery();
            conn.Close();
            return rowsAffected;
        }

        // Executes a SQL query and checks if it returns any results
        public static bool Exists(string fileName, string sql)
        {

            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader data = com.ExecuteReader();

            bool found = Convert.ToBoolean(data.Read());
            conn.Close();
            return found;

        }

        // Executes a SQL query and returns the results in a DataTable
        public static DataTable GetDataTable(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            DataTable dt = new DataTable();
            SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);
            tableAdapter.Fill(dt);

            return dt;
        }
    }
}



