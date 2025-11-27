using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using System.IO;

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

        protected void testHash(object sender, EventArgs e) {
            string inputString = "Cse445!";

            byte[] inputBytes = Encoding.UTF8.GetBytes(inputString);

            using (SHA384Managed sha384 = new SHA384Managed())
            {
                byte[] hashBytes = sha384.ComputeHash(inputBytes);
                string hexHash = BitConverter.ToString(hashBytes);

                Debug.WriteLine(inputString);
                Debug.WriteLine(hexHash);

                string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Staff.xml");
                XDocument doc = XDocument.Load(xmlFilePath);

                XElement parentElement = doc.Element("Staff");
                XElement newItem = new XElement("User", new XElement("Username", "TA"), new XElement("Password", hexHash));
                doc.Root.Add(newItem);

                doc.Save(xmlFilePath);

            }
        }

        protected void SignUp(object sender, EventArgs e) { 
            // FIXME: Actually implement signing up
        }
    }
}