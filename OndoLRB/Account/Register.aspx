<%@ Page Title="" Language="C#" MasterPageFile="~/Account/Auth.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="forms" Runat="Server">
    <div class=" row-fluid span10" >
        <div class="span4">
            <img src="../App_Themes/Default/img/Ondo-logo.jpg" />
            <h3>Land Records Bureau</h3>
            <h4>Alagbaka, Akure</h4>
        </div>
        <div class="span6">
             <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CssClass="form-horizontal" MembershipProvider="AspNet2MembershipProvider" OnCreatedUser="CreateUserWizard1_CreatedUser">
                 <HeaderStyle BackColor="" Font-Size="Large" />
                 <HeaderTemplate>
                     <h3>Create an Account</h3>
                 </HeaderTemplate>
                 <ContinueButtonStyle CssClass="btn" />
                 <CreateUserButtonStyle CssClass="btn btn-success" />
                 
        <WizardSteps>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" EnableTheming="true">
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
        </div>
    </div>
   
</asp:Content>

