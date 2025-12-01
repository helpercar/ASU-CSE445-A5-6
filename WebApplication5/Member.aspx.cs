using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null && (string)Session["UserType"] != "Staff" && (string)Session["UserType"] != "Member")
            {
                // Redirect to Login if not the right user type, the login will redirect to default if already Logged in
                Response.Redirect("Login.aspx");
            }
        }

        protected void MathLoad(object sender, EventArgs e) {
            Response.Redirect("Math.aspx");
        }

        protected void WordLoad(object sender, EventArgs e)
        {
            Response.Redirect("WordFilter.aspx");
        }
    }
}