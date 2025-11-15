using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isLoggedIn = Session["IsLoggedIn"] as bool? ?? false;
            Image1.ImageUrl = "~/imageprocess.aspx";    // Loads the captcha

            if (Session["UserID"] != null ||  isLoggedIn)
            {
                Response.Redirect("Default.aspx");
            }

            
            
        }

        protected void captchaLoad(object sender, EventArgs e) {
            MyImageService.ServiceClient fromService = new MyImageService.ServiceClient();
            string length = "5";
            Session["userLength"] = length;

            string myStr = fromService.GetVerifierString(length);
            Session["generatedString"] = myStr;
        }

        protected void LoginTest(object sender, EventArgs e)
        {
            Debug.WriteLine("Testing");

            string username = loginUsername.Text;
            string password = loginPassword.Text;

            Debug.WriteLine(Session["generatedString"]);

            if ((string)Session["generatedString"] == TextBox1.Text)
            {
                // Successful captcha
                // Malcom Myers - Creating a Cookie Authorization
                if (username == "TA" && password == "Cse445!")
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(username, false);

                    Session["UserID"] = 10;

                    Response.Redirect("~/Default.aspx");
                }
                else { 
                    // This if statement is purely for testing a possible login function and will be fleshed out for Assignment 6
                }
            }
            else {
                // Unsuccessful captcha
                // Generates a new Captcha on failure
                captchaLoad(sender, e);
            }

            
        }

        protected void SignUp(object sender, EventArgs e) { 
            // FIXME: Actually implement signing up
        }
    }
}