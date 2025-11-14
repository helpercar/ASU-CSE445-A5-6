using System;
using System.Collections.Generic;
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

        }
        protected void memberCheck(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Cookies["login"] != null)
            {
                // Case for there is a login cookie

            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
        protected void adminCheck(object sender, EventArgs e) {
            bool isLoggedIn = Session["IsLoggedIn"] as bool? ?? false;

            if (Session["UserID"] != null || isLoggedIn) {
                if ((int)Session["UserID"] == 10)
                {
                    Response.Redirect("~/About.aspx");
                }
                else
                {
                    Response.Redirect("~/Contact.aspx");
                }
            }
            else {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}