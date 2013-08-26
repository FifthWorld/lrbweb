<%@ Page Title="" Language="C#" MasterPageFile="~/User/Forms/formsMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="User_Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="forms" Runat="Server">
    <div class="row-fluid">
        <div class="span12 offset2">
            <h4>
                Choose a form category
            </h4>
            <div class="row-fluid">
                <div class="span6 well">
                <a href="Individual.aspx">Register as an individual</a>
                </div>
                </div>
            <div class="row-fluid">
            <div class="span6 well">
                <a href="CorporateForm.aspx">Register as an Organization</a>
            </div>
                </div>
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>

