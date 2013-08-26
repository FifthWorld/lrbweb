<%@ Page Title="" Language="C#" MasterPageFile="~/Account/Auth.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="forms" runat="Server">
    <div class="row-fluid">
        <div class="row-fluid span9 offset3">
            <h3>Welcome to Ondo state Land Records Bureau</h3>
        </div>

        <div class="span3">
            <img src="../App_Themes/Default/img/Ondo-logo.jpg" />
            <div>
                <h4 style="font-family: Segoe UI">Land Records Bureau</h4>
                <h5>Alagbaka, Akure, Ondo state</h5>
            </div>
        </div>
        <div class="span4">
            <asp:Login ID="Login1" runat="server" CssClass="row-fluid" DestinationPageUrl="~/User/Default.aspx" CreateUserUrl="~/Account/Register.aspx" CreateUserText="Register" VisibleWhenLoggedIn="False" MembershipProvider="AspNet2MembershipProvider">
                <LayoutTemplate>
                    <div class="form-horizontal">
                        <div class="span5">
                            <div class="control-group">
                                <label class="control-label" for="username"><b>Username</b></label>
                                <div class="controls">
                                    <asp:TextBox runat="server" ID="username" CssClass="input-xlarge" />
                                </div>
                            </div>
                            <div class="control-group">
                                <label class="control-label" for="password"><b>Password</b></label>
                                <div class="controls">
                                    <asp:TextBox runat="server" ID="password" TextMode="Password" CssClass="input-xlarge" /><br />
                                </div>
                            </div>
                            <div class="control-group">
                                <div class="controls">
                                    <asp:Button runat="server" ID="login" Text="Login" CssClass="btn" CommandName="Login" />
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </LayoutTemplate>
            </asp:Login>
        </div>
    </div>
</asp:Content>

