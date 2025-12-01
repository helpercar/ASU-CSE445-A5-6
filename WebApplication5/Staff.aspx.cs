using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

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
            string username = signUpUsername.Text;
            string password = signUpPassword.Text;

            byte[] inputBytes = Encoding.UTF8.GetBytes(password);

            using (SHA384Managed sha384 = new SHA384Managed())
            {
                byte[] hashBytes = sha384.ComputeHash(inputBytes);
                string hexHash = BitConverter.ToString(hashBytes);

                Debug.WriteLine(password);
                Debug.WriteLine(hexHash);

                string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Staff.xml");
                XDocument doc = XDocument.Load(xmlFilePath);

                XElement parentElement = doc.Element("Staff");
                XElement newItem = new XElement("User", new XElement("Username", username), new XElement("Password", hexHash));
                doc.Root.Add(newItem);

                doc.Save(xmlFilePath);

            }
        }
    }
}