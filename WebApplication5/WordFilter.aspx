<%@ Page Title="Word Filter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WordFilter.aspx.cs" Inherits="WebApplication5.WordFilter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
        <body>
                <div>
                    <h2>Word Filter Service</h2>
                    <p>Enter text to filter:</p>
                    <asp:TextBox ID="TextInput" runat="server" Width="300px" TextMode="MultiLine" Rows="5"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Filter Text" OnClick="Button1_Click" />
                    <br />
                    <br />
                    <h3>Filtered Result:</h3>
                    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
                    <br />
                    <br /> 
                    <h3>Reversed Result:</h3>
                    <asp:Label ID="LabelReverse" runat="server" Text=""></asp:Label>
                </div>
        </body>
    </html>
</asp:Content>