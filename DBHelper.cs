
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.Hosting;

/// <summary>
/// Class Helper helps with Database actions
/// </summary>
/// 

namespace IttaiWebDemo
{
    public class Helper
    {
        public static SqlConnection ConnectToDb(string fileName)
        {
			string dbName = fileName;
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + HostingEnvironment.ApplicationPhysicalPath + "App_Data\\"+ dbName + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public static void DoQuery(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
        }



        public static bool IsExist(string fileName, string sql)
        {

            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader data = com.ExecuteReader();

            bool found = Convert.ToBoolean(data.Read());
            conn.Close();
            return found;

        }

        public static DataTable ExecuteDataTable(string fileName, string sql)
        {
            SqlConnection conn = ConnectToDb(fileName);
            conn.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);

            tableAdapter.Fill(dt);
            conn.Close();

            return dt;
        }

    }
}



