using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApplicationLibrary;
using ApplicationLibrary.Data;
using System.IO;


public partial class User_Forms_Default : System.Web.UI.Page
{
    //initialize the sola application service
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Application_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if(this.ContactInfoControl.save()==true && this.ApplicantInfoControl.save()==true && this.PropertyInfoControl.save()==true)
        {
            var appService = new SolaApplicationService();
            Address add = new Address
            {
                City = ContactInfoControl.City,
                State = ContactInfoControl.State,
                PMBNo = ContactInfoControl.PoBox,
                Street = ContactInfoControl.StreetName
            };

            Document doc = new Document();
            doc.Description = Session["desc"].ToString();
            doc.DocumentType = Session["type"].ToString();
            doc.FileName = Session["name"].ToString();
            doc.Extension = Session["type"].ToString(); 
            string file=Session["path"].ToString();
            doc.Content = File.ReadAllBytes(file);

            Property prop = new Property();
            Address propAddr = new Address();
            propAddr.PMBNo = "nothing";
            propAddr.Street = this.PropertyInfoControl.PropertyLocation;
            propAddr.State = "Ondo state";
            propAddr.City =this.PropertyInfoControl.PropertyLocation;
            prop.Addresses.Add(propAddr);
            prop.CapacityofOwnership = this.PropertyInfoControl.CapacityOfOwnership;
            prop.Developed = this.PropertyInfoControl.Developed;
            prop.LandUse = this.PropertyInfoControl.LandUse;
            prop.PeriodofPossession = this.PropertyInfoControl.LengthOfOwnership;
            prop.ApproximateArea = Convert.ToDecimal(this.PropertyInfoControl.ApproximateArea);
            //prop.Developed=this.PropertyInfoControl.

            appService.app.ContactPerson.Addresses.Add(add);
            appService.app.UserId = "samuelNet";
            appService.app.ContactPerson.DOB = this.ApplicantInfoControl.DateOfBirth;
            appService.app.ContactPerson.Email = this.ContactInfoControl.Email;
            appService.app.ContactPerson.EmployerAddress = this.ApplicantInfoControl.EmployerAddress;
            appService.app.ContactPerson.EmployerName = this.ApplicantInfoControl.EmployerName;
            appService.app.ContactPerson.Fax = this.ContactInfoControl.Fax;
            appService.app.ContactPerson.Firstname = this.ApplicantInfoControl.FirstName;
            appService.app.ContactPerson.Gender = this.ApplicantInfoControl.Sex;
            appService.app.ContactPerson.HomeNo = this.ContactInfoControl.Phone2;
            appService.app.ContactPerson.HomeTown = this.ApplicantInfoControl.LGA;
            appService.app.ContactPerson.LGA = this.ApplicantInfoControl.LGA;
            appService.app.ContactPerson.Middlename = this.ApplicantInfoControl.Othernames;
            appService.app.ContactPerson.MobileNo = this.ContactInfoControl.Phone;
            appService.app.ContactPerson.Occupation = this.ApplicantInfoControl.Occupation;
            appService.app.ContactPerson.OfficeNo = this.ContactInfoControl.Phone2;
            appService.app.ContactPerson.StateofOrigin = this.ApplicantInfoControl.StateOfOrigin;
            appService.app.ContactPerson.Surname = this.ApplicantInfoControl.SurName;
            appService.app.OtherRelevantInfo = this.PropertyInfoControl.RelevantInfo;
            appService.app.Documents.Add(doc);
            appService.app.Properties.Add(prop);
            appService.app.StartDate = DateTime.Now;
            appService.app.SubmittedbyApplicant = true;
            appService.save();
            File.Delete(file);
            Response.Redirect("Success.aspx");

        }
        else
        {
            //Load Party information
            //Load property information
            Response.Redirect("~/User/Certificates.aspx");
        }
        
    }


    protected void category_SelectedIndexChanged(object sender, EventArgs e)
    {
       /* if (category.SelectedValue == "1")
            Wizard1.ActiveStepIndex=0;
        else if(category.SelectedValue =="2")
            Wizard1.ActiveStepIndex=1;
        * */
    }
    private byte[] DocConverter(Stream stream)
    {
        byte[] buffer = new byte[16 * 1024];
        using (MemoryStream ms = new MemoryStream())
        {
            //int read;
            //while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            //{
            //    ms.Write(buffer, 0, read);
            //}
            //return ms.ToArray();
            stream.CopyTo(ms);
            return ms.ToArray();
        }
    }
}