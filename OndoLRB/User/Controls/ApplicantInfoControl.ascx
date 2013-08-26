<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ApplicantInfoControl.ascx.cs" Inherits="User_Controls_ApplicantInfoControl" %>
<div id="applicantInfo">
    <asp:Panel runat="server" ID="applicantInfoPanel">
        <div id="PersonalInfo">
            <!--Personal info Section -->
            <h3>Personal Information</h3>
            <%-- Row Holds the entire row while span3 represents a column. --%>
            <div class="row">
                <div class="span3">                    
                    <label for="surname">Surname</label>
                    <input type="text" runat="server" id="surname" placeholder="Surname" />
                </div>
                <div class="span3">
                    <label for="firstname">Firstname</label>
                    <input type="text" id="firstname" runat="server" placeholder="Firstname" />
                </div>
                <div class="span3">
                    <label for="othernames">Middle name</label>
                    <input type="text" runat="server" id="othernames" placeholder="Othernames" />
                </div>  
                <div class="span3">
                    <label for="dateofBirth">Date of Birth</label>
                    <div class="input-append date" id="dp3" data-date="12-02-2012" data-date-format="dd-mm-yyyy">
                        <input id="dateofBirth" class="span2" size="18" type="text" value="12-02-1978" runat="server">
                        <span class="add-on"><i class="icon-th"></i></span>
                    </div>
                </div>  
                <div class="span3">
                    <label for="sex">Sex</label>
                    <select runat="server" id="sex">
                        <option id="Option1" runat="server" value="male">Male</option>
                        <option id="Option2" runat="server" value="female">Female</option>
                    </select>
                </div>
                <div class="span3">
                    <label for="occupation">Occupation</label>
                    <input type="text" runat="server" id="occupation" />
                </div>                
                <div class="span3">
                    <label for="lga">Local Government Area</label>
                    <input type="text" runat="server" id="lga" placeholder="Home town and LGA" />
                </div>
                <div class="span3">
                    <label for="stateOfOrigin">State of Origin</label>
                    <select runat="server" id="stateOfOrigin">
                        <option id="Option3" runat="server" value="ondo">Ondo</option>
                        <option id="Option4" runat="server" value="oyo">Oyo</option>
                    </select>
                </div>
            </div>
            <div class="row">
                <div class="span3">
                    <label for="formerEmployerName">Name of Former Employer</label>
                    <textarea type="text" runat="server" id="formerEmployerName" class="" />
                </div>
                <div class="span3">
                    <label for="formerEmployerAddress">Address of former employer</label>
                    <textarea type="text" runat="server" id="formerEmployerAddress" class="" />
                </div>
            </div>
        </div>
    </asp:Panel>
</div>
<script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/jquery.js"></script>
<script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/bootstrap.min.js"></script>
<script type="text/javascript" src="../../App_Themes/SiteTheme/bootstrap/js/bootstrap-datepicker.js"></script>
<script type="text/javascript">
    var startDate = new Date(1900, 1, 1);
    var endDate = new Date(1996, 12, 30);
    $('#dp3').datepicker()
    .on("changeDate", function (ev) {
        if (ev.date.valueOf() < startDate.valueOf() || ev.date.valueOf() > endDate) {
            alert("Invalid date selected");
            $('#dp3').datepicker("setValue", "12-02-1978");
        }
    }
    );
</script>