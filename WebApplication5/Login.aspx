<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication5.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />
    <main aria-labelledby="title">
        <h1>Login</h1>
        <p>
            <label for="username1">Username:</label>
            <asp:TextBox ID="loginUsername" runat="server" placeholder="Enter your username"></asp:TextBox>
        </p>
        <p>
            <label for="password1">Password:</label>
            <asp:TextBox ID="loginPassword" runat="server" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
        </p>
        <div>
            <asp:Image ID="Image1" Visible="true" runat="server" />
            <asp:TextBox ID="TextBox1" runat="server" />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="LoginTest" class="btn btn-default" style="background-color: blue; color: white;" />
        </div>

        <h1>Sign Up</h1>
        <p>
            <label for="username2">Username:</label>
            <asp:TextBox ID="signUpUsername" runat="server" placeholder="Enter your username"></asp:TextBox>
        </p>
        <p>
            <label for="password2">Password:</label>
            <asp:TextBox ID="signUpPassword" runat="server" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
        </p>
        <asp:Button ID="btnSignUp" runat="server" Text="Login" OnClick="SignUp" class="btn btn-default" style="background-color: blue; color: white;" />
    </main>
</asp:Content>