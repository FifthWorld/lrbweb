using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApplicationLibrary;
using System.Text.RegularExpressions;

public partial class User_Controls_ContactInfoControl : System.Web.UI.UserControl,ISaveable
{
    
    //public bool isValidControls { get; set; }//public property to ascertain the validity of the user control
    private bool _isValid;
    //private fields for retrieving the data from this user control
    #region private fields
    private string _streetName;
    private string _city;
    private string _poBox;
    private string _state;
    private string _email;
    private string _phone;
    private string _phone2;
    private string _fax;
    private string _permAddr;
    #endregion

    //public properties for manipulating this field
    #region public properties
    public string StreetName
    {
        get { return _streetName; }
        set { _streetName = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string PoBox
    {
        get { return _poBox; }
        set { _poBox = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    public string Phone2
    {
        get { return _phone2; }
        set { _phone2 = value; }
    }
    public string Fax
    {
        get { return _fax; }
        set { _fax = value; }
    }
    public string PermAddr
    {
        get { return _permAddr; }
        set { _permAddr = value; }
    }
    #endregion
    //end of public properties
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    internal void LoadForm()
    {

    }
    internal void packData()
    {
        StreetName = streetName.Value;
        City = city.Value;
        PoBox = poBox.Value;
        State = state.Value;
        Email = email.Value;
        Phone = phone.Value;
        Phone2 = phone2.Value;
        Fax = fax.Value;
        PermAddr = permAddr.Value;
    }

    public bool save()
    {
       
            if (validate() == 1)
            {
                packData();
                return true;
            }
            else return false;
    }

   /* private void LoadParty(ApplicationLibrary.Data.Party party)
    {
        if (party != null)
        {
          
            
        }
    }*/
    /**
     * 
     * Validate on application submission not during the application filling stage. Unless we wanna implement javascript validators
     * */
    public int validate()
    {
        //run thru the contact information fields to chck that the filled fields are valid
        //Trick is to single out those fields that can be violated and whose violation can be handled
        /**
         * Validation approach:
         * for true, return 1
         * for false, return 0
         * 
         * */
        if (checkNull())
        {
            packData();
            //Load fields in the Properties
            //validate email
            string regstring = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            if (Regex.IsMatch(Email, regstring, RegexOptions.IgnoreCase))
            {
                if (Regex.IsMatch(Phone, "") || Regex.IsMatch(Phone2, ""))
                {
                    _isValid = true;
                    return 1;
                }
                else return 0;
            }
            else return 0;
        }
        else return 0;
       
    }


    public bool isControlValid()
    {
        return _isValid;
    }
    private bool checkNull()
    {
        //check the compulsory fields that they are not null or empty
        /**
         * compulsory fields include:
         * 1. Street address
         * 2. City
         * 3. State
         * 4. Phone
         * 5. Email
         * 6. PermAddr
         **/
        if (streetName.Value != "" && city.Value != "" && state.Value != "" && phone.Value != "" && email.Value != "" && permAddr.Value != "")
        {
            return true;
        }
        else return false;
         
    }
}