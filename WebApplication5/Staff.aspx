<%@ Page Title="Staff" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="WebApplication5.Staff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div>
            <h1>Staff Page</h1>
            <h2>Sign Up New Staff</h2>
            <p>
                <label for="username1">Username:</label>
                <asp:TextBox ID="signUpUsername" runat="server" placeholder="Enter your username"></asp:TextBox>
            </p>
            <p>
                <label for="password1">Password:</label>
                <asp:TextBox ID="signUpPassword" runat="server" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
            </p>
            <asp:Button ID="btnSignUp" runat="server" Text="Add" OnClick="Add_Staff" class="btn btn-default" style="background-color: blue; color: white;" />
        </div>
    </main>
</asp:Content>
