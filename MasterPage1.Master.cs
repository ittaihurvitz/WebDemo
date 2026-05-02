using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IttaiWebDemo
{
    public partial class MasterPage1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Convert.ToBoolean(Session["LoggedIn"]))
            {
                menuAbout.Style.Add("display", "block");
                menuHistory.Style.Add("display", "block");
                menuCircle.Style.Add("display", "block");
                menuLines.Style.Add("display", "block");
                menuCouples.Style.Add("display", "block");
            }
            else
            {
                menuAbout.Style.Add("display", "none");
                menuHistory.Style.Add("display", "none");
                menuCircle.Style.Add("display", "none");
                menuLines.Style.Add("display", "none");
                menuCouples.Style.Add("display", "none");
            }
        }
    }
}