using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IttaiWebDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String uName = userName.Value;
                message.InnerText = "Hello " + uName;
            }

        }
        protected void registerButton_Click(object sender, EventArgs e)
        {
            String uName = userName.Value;
            String pass = password.Value;
            String fName = firstName.Value;
            String lName = lastName.Value;
            string fileName = "Database1.mdf";
            string SQLString = "INSERT INTO tblUsers (UserName, Password, FirstName, LastName, Admin) VALUES ('" + uName + "', '" + pass + "', '" + fName + "', '" + lName + "', '" + false + "')";
            int rowsAffected = DBHelper.DoNonQuery(fileName, SQLString);
            if (rowsAffected > 0)
            {
                message.InnerText = "User registered successfully. Please login with you user name and password";
            }
            else
            {
                message.InnerText = "Error registering user.Please try with another user name";
            }
        }
    }
}