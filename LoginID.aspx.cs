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
    public partial class LoginID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Check the user name and password                
                String idNum = idNumber.Value;
                String pass = password.Value;

                string fileName = "Database1.mdf";
                string SQLString = "SELECT * FROM tblUsers WHERE IDNumber='" + idNum + "' AND Password='" + pass + "'";
                if (DBHelper.Exists(fileName, SQLString))
                {
                    // Get fisrt name, last name and admin status
                    SQLString = "SELECT UserName, FirstName, LastName, Admin FROM tblUsers WHERE IDNumber='" + idNum + "'";
                    DataTable dt  = DBHelper.GetDataTable(fileName, SQLString);
                    string userName = dt.Rows[0]["UserName"].ToString();
                    string firstName = dt.Rows[0]["FirstName"].ToString();
                    string lastName = dt.Rows[0]["LastName"].ToString();
                    bool admin = Convert.ToBoolean(dt.Rows[0]["Admin"]);
                    // Set the message to be displayed
                    string messageText;

                    // Set the session variable to store the user name
                    Session["UserName"] = userName;
                    Session["LoggedIn"] = true;

                    if (admin)
                    {
                        messageText = "Hello " + firstName + " " + lastName + ". You are an administrator.";
                        Session["Admin"] = true;
                    } else
                    {
                        messageText = "Hello " + firstName + " " + lastName + ".";
                        Session["Admin"] = false;
                    }
                        
                    message.InnerText = messageText;
                    Response.Redirect("About.aspx");
                }
                else
                {
                    message.InnerText = "Invalid username or password.";
                    Session["UserName"] = "Visitor";
                    Session["LoggedIn"] = false;
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

    }
}