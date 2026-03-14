using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IttaiWebDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Check the user name and password                
                String uName = userName.Value;
                String pass = password.Value;

                string fileName = "Database1.mdf";
                string SQLString = "SELECT * FROM tblUsers WHERE UserName='" + uName + "' AND Password='" + pass + "'";
                if (DBHelper.Exists(fileName, SQLString))
                {
                    // Get fisrt name, last name and admin status
                    SQLString = "SELECT FirstName, LastName, Admin FROM tblUsers WHERE UserName='" + uName + "'";
                    DataTable dt  = DBHelper.GetDataTable(fileName, SQLString);
                    string firstName = dt.Rows[0]["FirstName"].ToString();
                    string lastName = dt.Rows[0]["LastName"].ToString();
                    bool admin = Convert.ToBoolean(dt.Rows[0]["Admin"]);
                    // Set the message to be displayed
                    string messageText;
                    if (admin)
                    {
                        messageText = "Hellow " + firstName + " " + lastName + ". You are an administrator.";
                    } else
                    {
                        messageText = "Hellow " + firstName + " " + lastName + ".";
                    }
                        
                    message.InnerText = messageText;
                }
                else
                {
                    message.InnerText = "Invalid username or password.";
                }
            }
        }

        public DataSet RetrieveUsersTable(string SQLStr)
        {
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLStr, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Users");

            string fileName = "Database1.mdf";
            DataTable dt = DBHelper.GetDataTable(fileName, SQLStr);


            return ds;
        }

        int BackupPageLoadBeforeDeleteCode()
        {
            if (IsPostBack)
            {
                //Get data from database
                DataSet ds = new DataSet();
                string SQLStr = "SELECT * FROM tblUsers";
                ds = RetrieveUsersTable(SQLStr);


                // Check the user name and password                
                String uName = userName.Value;
                String pass = password.Value;

                string fileName = "Database1.mdf";
                string SQLString = "SELECT * FROM tblUsers WHERE UserName='" + uName + "' AND Password='" + pass + "'";
                if (DBHelper.Exists(fileName, SQLString))
                {
                    //Response.Redirect("Welcome.aspx");
                    message.InnerText = "Hellow " + uName;
                }
                else
                {
                    message.InnerText = "Invalid username or password.";
                }
            }

            return 1;
        }
    }
}