<%@ Page Title="Member" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="WebApplication5.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div>
            <h1>Welcome to the Member Page</h1>
            <h2>How To Access Services</h2>
            <p>
                Math Services: 
            </p>
            <p>
                <asp:button class="btn btn-default" style="background-color: blue; color: white;" OnClick="MathLoad" runat="server" Text="Math Access"></asp:button>
            </p>
            <p>
                Word Filter Services: 
            </p>
            <p>
                <asp:button class="btn btn-default" onClick="WordLoad" style="background-color: blue; color: white;" Text="Word Filter Access" runat="server"></asp:button>
            </p>
        </div>
    </main>
</asp:Content>
