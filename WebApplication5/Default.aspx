<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            <section>
                <h2>Current Functionality</h2>
                <p>
                    <%-- FIXME: Add the actual Functionality once it is created --%>
                    Currently, you can log in using the proper credentials for staff.
                </p>
                <p>
                    You May also choose the Math Tab for different kinds of Math Functions!
                </p>
            </section>
            <section>
                <h2>How To Access Services</h2>
                <p>
                    Member Access of Services: 
                </p>
                <p>
                    <asp:button class="btn btn-default" style="background-color: blue; color: white;" OnClick="memberCheck" runat="server" Text="Member Access"></asp:button>
                </p>
                <p>
                    Admin Access of Services: 
                </p>
                <p>
                    <asp:button class="btn btn-default" onClick="adminCheck" style="background-color: blue; color: white;" Text="Admin Access" runat="server"></asp:button>
                </p>
                <%-- Add a Button That leads to the sign in page --%>
            </section>
        </div>
    </main>

</asp:Content>
