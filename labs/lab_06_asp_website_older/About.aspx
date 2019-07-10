<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="lab_06_asp_website_older.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Hello!<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h2>
    <h3>This is an older website<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h3>
    <p>
        <asp:Button ID="Button1" runat="server" Height="60px" OnClick="Button1_Click" Text="Click here for an updated one!" Width="251px" />
    </p>
</asp:Content>
