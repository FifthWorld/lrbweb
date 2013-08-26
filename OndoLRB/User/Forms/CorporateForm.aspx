<%@ Page Title="" Language="C#" MasterPageFile="~/User/Forms/formsMaster.master" AutoEventWireup="true" CodeFile="CorporateForm.aspx.cs" Inherits="User_Forms_CorporateForm" %>

<%@ Register Src="~/User/Controls/CorporateUserControl.ascx" TagPrefix="uc1" TagName="CorporateUserControl" %>
<%@ Register Src="~/User/Controls/ContactInfoControl.ascx" TagPrefix="uc1" TagName="ContactInfoControl" %>
<%@ Register Src="~/User/Controls/PropertyInfoControl.ascx" TagPrefix="uc1" TagName="PropertyInfoControl" %>
<%@ Register Src="~/User/Controls/CorporateDocControl.ascx" TagPrefix="uc1" TagName="CorporateDocControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="forms" Runat="Server">
    <div class="span6 offset3"><h3>Corporate Registration</h3></div>
    <asp:Wizard ID="Wizard1" runat="server" StartNextButtonStyle-CssClass="btn btn-primary btn-medium" 
        StepNextButtonStyle-CssClass="btn btn-primary btn-medium" FinishPreviousButtonStyle-CssClass="btn btn-cancel btn-medium"
        FinishCompleteButtonStyle-CssClass="btn btn-success btn-medium" CancelButtonStyle-CssClass="btn btn-danger btn-medium"
        NavigationButtonStyle-CssClass="btn btn-cancel btn-medium" SideBarButtonStyle-CssClass="span3 bs-docs-sidenav" OnFinishButtonClick="Wizard1_FinishButtonClick"
        FinishDestinationPageUrl="~/User/Default.aspx"
        >
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Organization information">
                <uc1:CorporateUserControl runat="server" ID="CorporateUserControl" />
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Contact Information">
                <uc1:ContactInfoControl runat="server" ID="ContactInfoControl" />
            </asp:WizardStep>
            <asp:WizardStep runat="server" ID="Wizardstep3" Title="Registration Documents">
                <uc1:CorporateDocControl runat="server" ID="CorporateDocControl" />
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep4" runat="server" Title="Property Information">
                <uc1:PropertyInfoControl runat="server" ID="PropertyInfoControl" />
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>

