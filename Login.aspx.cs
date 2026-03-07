using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
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
                //Get data from database
                DataSet ds = new DataSet();
                string SQLStr = "SELECT * FROM tblUsers";
                ds = RetrieveUsersTable(SQLStr);


                // Check the user name and password                
                String uName = userName.Value;
                String pass = password.Value;

                if (uName == "ittai" && pass == "1234")
                {
                    //Response.Redirect("Welcome.aspx");
                    message.InnerText = "Hellow " + uName;
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
            
            return ds;
        }
    }
}