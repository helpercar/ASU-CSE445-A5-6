using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Math : Page
    {
        MathService1.Service1Client mathServer;
        protected void Page_Load(object sender, EventArgs e)
        {
            // We want any user to be able to access the Math Service

            //if (Session["UserType"] == null && (string)Session["UserType"] != "Staff" && (string)Session["UserType"] != "Member")
            //{
            //    // Redirect to Login if not the right user type, the login will redirect to default if already Logged in
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            MathService1.Service1Client mathServer = new MathService1.Service1Client();
            //}
        }

        protected void Add(object sender, EventArgs e) {
            mathServer = new MathService1.Service1Client();

            if (val1.Text == "" || val2.Text == "")
            {
                calResult.Text = "Error!";
            }
            else
            {

                if (mathServer.checkIsInt(val1.Text) && mathServer.checkIsInt(val2.Text))
                {
                    int value1 = int.Parse(val1.Text);
                    int value2 = int.Parse(val2.Text);
                    int result = mathServer.add(value1, value2);

                    calResult.Text = result.ToString();
                }
                else
                {
                    calResult.Text = "Error!";
                }
            }
        }

        protected void Subtract(object sender, EventArgs e)
        {
            mathServer = new MathService1.Service1Client();
            if (val1.Text == "" || val2.Text == "")
            {
                calResult.Text = "Error!";
            }
            else
            {

                if (mathServer.checkIsInt(val1.Text) && mathServer.checkIsInt(val2.Text))
                {
                    int value1 = int.Parse(val1.Text);
                    int value2 = int.Parse(val2.Text);
                    int result = mathServer.subtract(value1, value2);

                    calResult.Text = result.ToString();
                }
                else
                {
                    calResult.Text = "Error!";
                }
            }
        }

        protected void Multiply(object sender, EventArgs e)
        {
            mathServer = new MathService1.Service1Client();
            if (val1.Text == "" || val2.Text == "")
            {
                calResult.Text = "Error!";
            }
            else
            {

                if (mathServer.checkIsInt(val1.Text) && mathServer.checkIsInt(val2.Text))
                {
                    int value1 = int.Parse(val1.Text);
                    int value2 = int.Parse(val2.Text);
                    int result = mathServer.multiply(value1, value2);

                    calResult.Text = result.ToString();
                }
                else
                {
                    calResult.Text = "Error!";
                }
            }
        }

        protected void Divide(object sender, EventArgs e)
        {
            mathServer = new MathService1.Service1Client();
            if (val1.Text == "" || val2.Text == "")
            {
                calResult.Text = "Error!";
            }
            else
            {

                if (mathServer.checkIsInt(val1.Text) && mathServer.checkIsInt(val2.Text))
                {
                    int value1 = int.Parse(val1.Text);
                    int value2 = int.Parse(val2.Text);


                    double result = mathServer.divide(value1, value2);

                    calResult.Text = result.ToString();
                }
                else
                {
                    calResult.Text = "Error!";
                }
            }
        }

        protected void CircleArea(object sender, EventArgs e) {
            mathServer = new MathService1.Service1Client();

            if (radius1.Text == "")
            {
                circleArea.Text = "Error!";
            }
            else {
                if (mathServer.checkIsInt(radius1.Text))
                {
                    int radius = int.Parse(radius1.Text);

                    double result = mathServer.circleArea(radius);

                    circleArea.Text = result.ToString();
                }
                else
                {
                    circleArea.Text = "Error!";
                }
            }
        }

        protected void ConeVolume(object sender, EventArgs e)
        {
            mathServer = new MathService1.Service1Client();

            if (radius2.Text == "" || height1.Text == "")
            {
                coneVolume.Text = "Error!";
            }
            else
            {
                if (mathServer.checkIsInt(radius2.Text) && mathServer.checkIsInt(height1.Text))
                {
                    int radius = int.Parse(radius2.Text);
                    int height = int.Parse(height1.Text);

                    double result = mathServer.coneVolume(radius, height);

                    coneVolume.Text = result.ToString();
                }
                else
                {
                    coneVolume.Text = "Error!";
                }
            }
        }
    }
}