using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Controls_ApplicantInfoControl : System.Web.UI.UserControl,ISaveable
{
    private bool _isValid;
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Othernames { get; set; }
    public string Sex { get; set; }
    public string Occupation { get; set; }
    public string EmployerName { get; set; }
    public string EmployerAddress { get; set; }
    public string LGA { get; set; }
    public string StateOfOrigin { get; set; }
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void PackData()
    {
        FirstName = firstname.Value;
        SurName = surname.Value;
        DateOfBirth = Convert.ToDateTime(dateofBirth.Value);
        Othernames = othernames.Value;
        Sex = sex.Value;
        Occupation = occupation.Value;
        EmployerName = formerEmployerName.Value;
        EmployerAddress = formerEmployerAddress.Value;
        LGA = lga.Value;
        StateOfOrigin = stateOfOrigin.Value;
    }
    internal void LoadForm()
    {

    }


    public bool save()
    {
        if (validate()==1)
        {
            PackData();
            return true;
        }
        else return false;
    }

    public bool isControlValid()
    {
        return _isValid;
    }

    public int validate()
    {
        if (checkNull() != false)
        {
            _isValid = true;
            return 1;
        }
        else
        {
            _isValid = false;
            return 0;
        }
    }
    private bool checkNull()
    {
        if (firstname.Value != "" && surname.Value != "" && dateofBirth.Value != "" && sex.Value != "" && occupation.Value != "" && formerEmployerName.Value != "" && formerEmployerAddress.Value != ""
            && lga.Value != "" && stateOfOrigin.Value != "")
        {
            return true;
        }
        else return false;
    }
}