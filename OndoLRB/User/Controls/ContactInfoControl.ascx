<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactInfoControl.ascx.cs" Inherits="User_Controls_ContactInfoControl" %>
<div id="contactInfoContainer">
    <asp:Panel ID="contactInfoPanel" runat="server">
        <!--Present Contact Address in Nigeria -->
        
        <div id="presentAddress" >
            <h5>Contact Information</h5>
              <table>
                  <tr>
                      <td>
                           <!--Address -->
            <label for="streetName">Home Address</label>
            <input type="text" id="streetName" runat="server" placeholder="Street number, Street Name, Address" required />
                      </td>
                      <td>
                          <!--City -->
            <label  for="city">City/Town</label>
            <input type="text" id="city" runat="server" placeholder="City/Town" required />
                      </td>
                      <td>
                          <!--PMB or P.O. Box -->
            <label for="poBox">P.M.B or P.O.Box</label>
            <input type="text" runat="server" id="poBox" placeholder="P.M.B or P.O.Box" />
                      </td>
                  </tr>

                  <tr>
                      
                      <td>
                           <!--State -->
             <label for="state">State</label>
            <select runat="server" id="state" required>
                <option id="Option1" runat="server" value="ondo">Ondo</option>
                <option id="Option2" runat="server" value="oyo">Oyo</option>
            </select>
                      </td>
                       <td>
 <!-- Email -->
            <label for="email">Email</label>
            <input type="email" runat="server" id="email" placeholder="Email.." required />
                      </td>
                  </tr>
                  <tr>
                      <td>
                          <!--Phone numbers -->
            <label for="phone">Office phone</label>
            <input type="tel" runat="server" id="phone" placeholder="Phone.." required />
                      </td>
                      <td>
                          <label for="phone2">Mobile</label>
            <input type="tel" runat="server" id="phone2" placeholder="Phone.." />
                      </td>
                     
                      <td>
                           <!--Fax -->
            <label for="fax">Fax</label>
            <input type="text" runat="server" placeholder="Fax" id="fax" />
                      </td>
                  </tr>
                  <tr>
                      <td colspan="2">
<!-- permanent home town address -->
        <div id="permanentHomeAddress">
            <label for="permAddr">Permanent Home Address</label>
           <input runat="server" id="permAddr" class="input-xxlarge" required />
        </div>

                      </td>
                      
                  </tr>

              </table>  
 
        </div>

    </asp:Panel>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery.js"></script>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery.validate.min.js"></script>
    <script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/additional-methods.min.js"></script>
    <script type="text/javascript">
        $("#presentAddress").validate();
    </script>
</div>