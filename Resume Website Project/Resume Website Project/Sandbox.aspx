<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sandbox.aspx.cs" Inherits="Resume_Website_Project.Sandbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
    <h1>Please, Log in.</h1>
    <font size="2" face="verdana" align="left" color="#8999E5">Username:<br /><asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <br />
     Password:</font> 
    <font size="2" face="verdana" align="left" color="#8999E5"><br />
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </font> <br />
    <asp:Button ID="ButtonLogin" runat="server" Text="log in" OnClick="ButtonLogin_Click" />

    </form>
</asp:Content>

