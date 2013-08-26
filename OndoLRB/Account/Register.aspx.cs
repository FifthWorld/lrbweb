using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        MembershipUser user = Membership.GetUser(CreateUserWizard1.UserName);
        Roles.AddUserToRole(user.UserName, "User");
        Response.Redirect("~/User/Default.aspx");
    }
}