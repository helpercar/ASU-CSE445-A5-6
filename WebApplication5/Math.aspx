<%@ Page Title="Math Functions" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Math.aspx.cs" Inherits="WebApplication5.Math" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="row">
            <section class="col-md-4">
                <h2>Basic Calculator</h2>
                <p>
                    <asp:Label runat="server" Text="Value 1: " />
                    <asp:TextBox runat="server" ID="val1" />
                </p>
                <p>
                    <asp:Label runat="server" Text="Value 2: " />
                    <asp:TextBox runat="server" ID="val2" />
                </p>
            </section>
            <section class="col-md-4">
                <h2>Options</h2>
                <asp:Button runat="server" Text="Add" OnClick="Add" class="btn btn-default" style="background-color: blue; color: white;" />
                <asp:Button runat="server" Text="Subtract" OnClick="Subtract" class="btn btn-default" style="background-color: blue; color: white;" />
                <asp:Button runat="server" Text="Multiply" OnClick="Multiply" class="btn btn-default" style="background-color: blue; color: white;" />
                <asp:Button runat="server" Text="Divide" OnClick="Divide" class="btn btn-default" style="background-color: blue; color: white;" />
            </section>
            <section class="col-md-4">
                <h2>Result</h2>
                <asp:Label runat="server" Text="Results: " />
                <asp:Label runat="server" ID="calResult" />
            </section>
        </div>
        <div class="row">
            <section class="col-md-4">
                <h2>Area of Circle</h2>
                <asp:Label runat="server" Text="Radius: " />
                <asp:TextBox runat="server" ID="radius1" />
            </section>
            <section class="col-md-4">
                <asp:Button runat="server" Text="Find Area" OnClick="CircleArea" class="btn btn-default" style="background-color: blue; color: white; margin-top: 35px;" />
            </section>
            <section class="col-md-4">
                <asp:Label runat="server" Text="Results: " />
                <asp:Label runat="server" ID="circleArea" />
            </section>
        </div>
        <div class="row">
            <section class="col-md-4">
                <h2>Volume of Cone</h2>
                <p>
                    <asp:Label runat="server" Text="Radius: " />
                    <asp:TextBox runat="server" ID="radius2" />
                </p>
                <p>
                    <asp:Label runat="server" Text="Height: " />
                    <asp:TextBox runat="server" ID="height1" />
                </p>
            </section>
            <section class="col-md-4">
                <asp:Button runat="server" Text="Find Volume" OnClick="ConeVolume" class="btn btn-default" style="background-color: blue; color: white; margin-top: 65px;" />
            </section>
            <section class="col-md-4">
                <asp:Label runat="server" Text="Results: " />
                <asp:Label runat="server" ID="coneVolume" />
            </section>
        </div>
    </main>
</asp:Content>
