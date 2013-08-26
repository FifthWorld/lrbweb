using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Controls_PropertyInfoControl : System.Web.UI.UserControl,ISaveable
{
    //public bool isValid { get; set; }
    private bool _isValid;

    #region Public properties
    public string PropertyLocation { get; set; }
    public string CapacityOfOwnership { get; set; }
    public string LandUse { get; set; }
    public string LengthOfOwnership { get; set; }
    public string ApproximateArea { get; set; }
    public string RelevantInfo { get; set; }
    public bool Developed { get; set; }
    //public string DevelopmentLevel { get; set; }
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #region DataLoader for submission
    private void packData()
    {
        PropertyLocation = propertyLoc.Value;
        CapacityOfOwnership = capacityOfOwnership.Value;
        LandUse = landUse.Value;
        LengthOfOwnership = lengthOfOwnership.Value;
        ApproximateArea = approximateArea.Value;
        RelevantInfo = relevantInfo.Value;
        Developed = Convert.ToBoolean(developmentLevel.Value);
    }
    #endregion

    internal void LoadForm()
    {

    }

    #region Data Persister
    public bool save()
    {
        if (validate() == 1)
        {
            packData();
            return true;
        }
        else return false;
    }
    #endregion

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
        else { _isValid = false; return 0; }
    }
    private bool checkNull()
    {
        if (propertyLoc.Value != "" && capacityOfOwnership.Value != "" && landUse.Value != "" && lengthOfOwnership.Value != ""
            && approximateArea.Value != "")
        {
            return true;
        }
        else return false;
    }
    
}