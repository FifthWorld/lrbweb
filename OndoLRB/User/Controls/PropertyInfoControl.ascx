<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PropertyInfoControl.ascx.cs" Inherits="User_Controls_PropertyInfoControl" %>
<div id="propertyInfo">
    <asp:Panel runat="server" ID="propertyInfoPanel">
        <h3>Property Information</h3>
        <table>
            <tr>
                <td colspan="2">
                    <!-- Property Location -->
                    <label for="propertyLoc">Where is the property located?</label>
                    <input type="text" runat="server" id="propertyLoc" class="input-xxlarge" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="capacityOfOwnership">In what capacity is this property owned?</label>
                    <select runat="server" id="capacityOfOwnership">
                        <option runat="server" value="self built">Self Built</option>
                        <option runat="server" value="purchase">By Purchase</option>
                        <option runat="server" value="inheritance">By Inheritance</option>
                    </select>
                </td>
                <td>
                    <label for="developmentLevel">Is this property developed?</label>
                    <select runat="server" id="developmentLevel">
                        <option runat="server" value="false">False</option>
                        <option runat="server" value="true">True</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="landUse">What is the land used for?</label>
                    <select runat="server" id="landUse">
                        <option runat="server" value="residential">Residential</option>
                        <option runat="server" value="commercial">Commercial</option>
                        <option runat="server" value="industrial">Industrial</option>
                        <option runat="server" value="recreational">Recreational</option>
                        <option runat="server" value="religious">Religious</option>
                        <option runat="server" value="Educational">Educational</option>
                    </select>
                </td>
               <td>
                    <label for="other">Others please specify</label>
                    <input type="text" runat="server" id="other" placeholder="Specify any other form of usage for the land" class="input-xlarge" />
                </td>
            </tr>

            <tr>
                <td>
                    <label for="lengthOfOwnership">How long has the property been in your possession?</label>
                    <input runat="server" id="lengthOfOwnership" type="number" />
                </td>
                </tr>
            <tr>
                <td>
                    <label for="approximateArea">Total size of plot</label>
                    <input type="number" id="approximateArea" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <label for="relevantInfo">Any other relevant information</label>
                    <input type="text" runat="server" id="relevantInfo" class="input-xlarge" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</div>