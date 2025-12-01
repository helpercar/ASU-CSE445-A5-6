using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["UserType"] != "Staff")
            {
                // Redirect to Login if not the right user type, the login will redirect to default if already Logged in
                Response.Redirect("Login.aspx");
            }
        }

        protected void Add_Staff(object sender, EventArgs e) { 
            
        }
    }
}