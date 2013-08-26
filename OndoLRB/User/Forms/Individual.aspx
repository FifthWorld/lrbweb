<%@ Page Title="" Language="C#" MasterPageFile="~/User/Forms/formsMaster.master" AutoEventWireup="true" CodeFile="Individual.aspx.cs" Inherits="User_Forms_Default" %>

<%@ Register Src="~/User/Controls/ContactInfoControl.ascx" TagPrefix="lrbUC" TagName="ContactInfoControl" %>
<%@ Register Src="~/User/Controls/ApplicantInfoControl.ascx" TagPrefix="lrbUC" TagName="ApplicantInfoControl" %>
<%@ Register Src="~/User/Controls/CorporateUserControl.ascx" TagPrefix="lrbUC" TagName="CorporateUserControl" %>
<%@ Register Src="~/User/Controls/PropertyInfoControl.ascx" TagPrefix="lrbUC" TagName="PropertyInfoControl" %>
<%@ Register Src="~/User/Controls/RegistrationDocumentsControl.ascx" TagPrefix="lrbUC" TagName="RegistrationDocumentsControl" %>

<asp:Content ID="Content2" ContentPlaceHolderID="forms" Runat="Server">
    
    <!-- Testing the wizard-->
    <asp:Wizard ID="Wizard1" runat="server" StartNextButtonStyle-CssClass="btn btn-primary btn-medium" 
        StepNextButtonStyle-CssClass="btn btn-primary btn-medium" FinishPreviousButtonStyle-CssClass="btn btn-cancel btn-medium"
        FinishCompleteButtonStyle-CssClass="btn btn-success btn-medium" CancelButtonStyle-CssClass="btn btn-danger btn-medium"
        NavigationButtonStyle-CssClass="btn btn-cancel btn-medium" SideBarButtonStyle-CssClass="span3 bs-docs-sidenav" OnFinishButtonClick="Application_FinishButtonClick"
        FinishDestinationPageUrl="~/User/Default.aspx"
        >
        <WizardSteps>
           
            <asp:WizardStep ID="personalInfo" runat="server" Title="Personal Information">
                <lrbUC:ApplicantInfoControl runat="server" ID="ApplicantInfoControl" />
            </asp:WizardStep>
             <asp:WizardStep ID="contactInfo" runat="server" Title="Contact Information">
                <lrbUC:ContactInfoControl runat="server" ID="ContactInfoControl" />
            </asp:WizardStep>
            <asp:WizardStep ID="uploadDocs" runat="server" Title="Upload Documents">
                <lrbUC:RegistrationDocumentsControl runat="server" ID="RegistrationDocumentsControl" />
            </asp:WizardStep>
            <asp:WizardStep ID="propertyInfo" runat="server" Title="Property Information">
                <lrbUC:PropertyInfoControl runat="server" ID="PropertyInfoControl" />
            </asp:WizardStep>
        </WizardSteps>
        
    </asp:Wizard>
</asp:Content>

