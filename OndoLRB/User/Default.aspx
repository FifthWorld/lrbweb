<%@ Page Title="" Language="C#" MasterPageFile="~/User/profilePage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <section id="dashboard">
        <h2>Welcome <% =User.Identity.Name %></h2>
    </section>
</asp:Content>