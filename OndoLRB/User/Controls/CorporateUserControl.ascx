<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CorporateUserControl.ascx.cs" Inherits="User_Controls_CorporateUserControl" %>
<div id="corporateControl">
    <!--This control is for corporate organizations -->
    <asp:Panel runat="server" ID="corporatePanel">
        <div class="row-fluid">
            <div class="span12">
                <table>
                    <tr>
                        <td>
                            <label>Registered Organization name</label>
                            <input type="text" class="input-xlarge" id="orgname" name="orgname" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Description</label>
                            <input type="text" runat="server" id="description" name="description" class="input-xlarge" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </asp:Panel>
   
</div>