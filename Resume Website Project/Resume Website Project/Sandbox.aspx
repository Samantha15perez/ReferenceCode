<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sandbox.aspx.cs" Inherits="Resume_Website_Project.Sandbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="150px" style="margin-top: 0px" Width="170px">
            <h1>Please, Log in.</h1>
            <font size="2" face="verdana" align="left" color="#8999E5">Username:<br /><asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Password:</font> <font size="2" face="verdana" align="left" color="#8999E5">
            <br />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="log in" />
            <br />
            <br />
            </font>
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server" EnableTheming="False" Height="482px" BackColor="Red">
            &nbsp;<asp:Image ID="Image1" runat="server" Height="369px" ImageUrl="~/App_Data/hqdefault.jpg" Width="522px" />
        </asp:Panel>

    </form>
</asp:Content>

 