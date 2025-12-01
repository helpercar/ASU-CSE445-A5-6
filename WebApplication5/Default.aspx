<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            <section>
                <h2>Current Functionality</h2>
                <p>
                    <%-- FIXME: Add the actual Functionality once it is created --%>
                    Currently, you can log in using the proper credentials for staff. You would need to solve a Captcha first, then a Session State is stored to keep track of the Username, UserID, and activates a session bool that stores whether or not the user is logged in. This in turn locks you out of the Login Page. (Marco)
                </p>
                <p>
                    You May also choose the Math Tab for different kinds of Math Functions such as basic multiplication, addition, subtraction and division or finding the area of a circle or volume of a cone. (Marco)
                </p>
                <p>
                    Currently, there is an global event handler to check whether or not a user is logged in, then activates a welcome message on the top toolbar. (Malcom)
                </p>
                <p>
                    There is also a StringUtilities.dll file that holds the function to reverse strings, which is used in the Word Filter tab. (Malcom)
                </p>
                <p>
                    The Word Filter Tab currently has a function that filters out common words from a given string. (Malcom)
                </p>
            </section>
            <section>
                <h2>How To Access Services</h2>
                <p>
                    Math Services: 
                </p>
                <p>
                    <asp:button class="btn btn-default" style="background-color: blue; color: white;" OnClick="MathPage" runat="server" Text="Math Access"></asp:button>
                </p>
                <p>
                    Word Filter Services: 
                </p>
                <p>
                    <asp:button class="btn btn-default" onClick="WordPage" style="background-color: blue; color: white;" Text="Word Filter Access" runat="server"></asp:button>
                </p>
                <%-- Add a Button That leads to the sign in page --%>
                <%-- Changed these buttons to say what they actually lead to, but gonna change them back once we implement the actual admin and member stuff --%>
            </section>
        </div>
    </main>

</asp:Content>
