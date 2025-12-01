using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Session["UserType"]);
        }
        protected void memberCheck(object sender, EventArgs e)
        {
            bool isLoggedIn = Session["IsLoggedIn"] as bool? ?? false;

            if (Session["UserType"] != null || isLoggedIn)
            {
                if ((string)Session["UserType"] == "Member" || (string)Session["UserType"] == "Staff")
                {
                    Response.Redirect("~/Member.aspx");
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
        protected void adminCheck(object sender, EventArgs e) {
            bool isLoggedIn = Session["IsLoggedIn"] as bool? ?? false;

            if (Session["UserType"] != null || isLoggedIn)
            {
                if ((string)Session["UserType"] == "Staff")
                {
                    Response.Redirect("~/Staff.aspx");
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}