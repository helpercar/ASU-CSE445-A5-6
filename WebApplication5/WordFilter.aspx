<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WordFilter.aspx.cs" Inherits="WebApplication5.WordFilter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word Filter</title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>