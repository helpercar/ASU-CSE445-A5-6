using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication5.WordFilterServiceReference;
using StringUtilities;

namespace WebApplication5
{
    public partial class WordFilter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null || (string)Session["UserType"] != "Staff" || (string)Session["UserType"] != "Member")
            {
                // Redirect to Login if not the right user type, the login will redirect to default if already Logged in
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Reverse String DLL
            StringUtils util = new StringUtils();

            String beforeText = TextInput.Text;

            String afterText = util.Rev_String(beforeText);

            LabelReverse.Text = afterText;


            // Word Filter Service
            Service1Client client = new Service1Client();

            string inputText = TextInput.Text;

            string filteredText = client.WordFilterer(inputText);

            LabelResult.Text = filteredText;


        }


    }
}