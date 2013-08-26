<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RegistrationDocumentsControl.ascx.cs" Inherits="User_Controls_RegistrationDocumentsControl" %>
<div id="regParticulars">
    <asp:Panel runat="server" ID="registration">
        <h3>Upload required documents</h3>
        <hr />
        <table>
            <tr>
                <td>
                    <label for="surveyPlan">Upload scanned copy of your survey plan</label>
                    <input id="surveyPlan" type="file" class="" name="surveyPlan" multiple="multiple" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="devLevyReciepts">Scanned copies of Ondo State Development Levy Receipts (For 3 years)</label>
                    <input id="devLevyReciepts" type="file" class="" name="devLevyReciepts[]" multiple="multiple" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <h4>Uploaded Documents</h4>
                    <hr />
                   <div class="progress progress-success progress-striped" id="progress">
                       <div class="bar"></div>
                   </div>
  <div id="result" class="bs-docs-example">
      
  </div>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery.js"></script>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery-ui-1.10.3.custom.min.js"></script>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery.fileupload.js"></script>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery.iframe-transport.js"></script>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/uploadScript.js">
    </script>
</div>
