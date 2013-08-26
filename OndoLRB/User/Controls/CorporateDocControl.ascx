<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CorporateDocControl.ascx.cs" Inherits="User_Controls_CorporateDocControl" %>
<asp:Panel runat="server" ID="orgDoc">
    <div class="=row-fluid">
        <div class="span9">
            <h4>Registration Documents</h4>
            <table class="table" style="width: 100%;">
                <tr>
                    <td>
                        <h5>Registration Certificate</h5>
                        <input type="file" name="regCert" id="regCert" class="btn" />
                    </td>
                   
                </tr>
                <tr>
                    <td>
                        <h5>Survey Plan</h5>
                        <input type="file" name="surveyPlan" id="surveyPlan" class="btn" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h5>Evidence of Ownership</h5>
                        <input type="file" name="evidenceOfOwnership" id="evidenceOfOwnership" class="btn" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h5>Levy Receipts</h5>
                        <input type="file" name="levyReciepts[]" id="levyReciepts" class="btn" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h5>Upploads</h5>
                        <div id="result"></div>
                    </td>
                </tr>
                
            </table>
        </div>
    </div>
</asp:Panel>