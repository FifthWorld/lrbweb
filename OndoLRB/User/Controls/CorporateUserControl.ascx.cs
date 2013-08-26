using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Controls_CorporateUserControl : System.Web.UI.UserControl,ISaveable
{
    private bool _isValid=false;
    public string OrganizationName { get; set; }
    public string OrganizationDesc { get; set; }
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public bool save()
    {
        if (validate() == 1 && _isValid==true)
        {
            packData();
            
            return true;
        }
        else return false;
        
    }
    private void packData()
    {

        OrganizationName=this.orgname.Value;
        OrganizationDesc=this.description.Value;
    }
    public bool isControlValid()
    {
        return _isValid;
    }

    public int validate()
    {
        if (this.orgname.Value != "" && this.description.Value != "")
        {
            _isValid = true;
            return 1;
        }
        else return 0;
    }
}