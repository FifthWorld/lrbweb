using ApplicationLibrary.Data;
using org.sola.services.boundary.wsclients;
using org.sola.webservices.casemanagement.extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLibrary
{
    public class SolaApplicationService
    {
        private SolaDbContext _context;

        public SolaDbContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
        private Application _app;

        public static string username = "test";
        public static string password = "test";

        public Application app
        {
            get { return _app; }
            set { _app = value; }
        }


        /*
         * This constructor instantiates the DbContext that is used during the
         * lifetime of this application
         * This constructor should be used when a new form is created
         */
        public SolaApplicationService()
        {
            Context = new SolaDbContext();
            app = new Application();
            app.StartDate = DateTime.Today;
            app.Parties.Add(new Party() { PartyType = "ContactPerson" });
        }

        public SolaApplicationService(int ApplicationId)
        {
            Context = new SolaDbContext();
            var getApp = Context.Applications.Where(p => p.Id == ApplicationId);

            if (getApp != null)
            {
                app = getApp.FirstOrDefault();
            }
            else
            {
                throw new Exception("No application is found with that ID...cheers");
            }
        }

        private applicationTO getAppTO()
        {
            applicationTO appTO = new applicationTO();
            appTO.nr = app.EntityKey.ToString();
            appTO.contactPerson = new partyTO();
            var property = app.Properties.FirstOrDefault();
            appTO.propertyList = new applicationPropertyTO[]{new applicationPropertyTO(){
                area= property.ApproximateArea.GetValueOrDefault(),
                propertyLoc=property.MainAddress
            }};

            appTO.contactPerson = new partyTO();
            appTO.contactPerson.fathersName = app.ContactPerson.Firstname;
            appTO.contactPerson.lastName = app.ContactPerson.Surname;
            appTO.contactPerson.email = app.ContactPerson.Email;
            appTO.contactPerson.corporateName = app.ContactPerson.OrganizationName;
            appTO.contactPerson.alias = app.ContactPerson.Firstname;
            appTO.contactPerson.dateOfBirth = app.ContactPerson.DOB.GetValueOrDefault();
            appTO.contactPerson.genderCode = app.ContactPerson.Gender;
            appTO.contactPerson.typeCode = app.ContactPerson.OrganizationName != null ? "nonNaturalPerson" : "naturalPerson";
            //homeTownTypeCode = app.Party.homeTownTypeCode,                
            //lgaTypeCode = app.Party.lgaTypeCode,
            //stateTypeCode = app.Party.stateCode,
            //titleTypeCode = app.Party.titleCode,
            appTO.contactPerson.mobile = app.ContactPerson.MobileNo;
            appTO.contactPerson.occupationTypeCode = app.ContactPerson.Occupation;
            appTO.contactPerson.rightHolder = true;


            appTO.contactPerson.address = new addressTO()
            {
                //description = app.ContactPerson.Addresses.FirstOrDefault,
            };
            appTO.contactPerson.preferredCommunicationCode = "phone";
            appTO.contactPerson.employerAddress = app.ContactPerson.EmployerAddress;
            appTO.contactPerson.employerName = app.ContactPerson.EmployerName;

            appTO = attachDocuments(app, appTO);
            appTO.serviceList = new serviceTO[]
            {
                new serviceTO(){
                    requestTypeCode="newDigitalTitle",
                    actionCode="lodge",
                    statusCode="lodged",                    
                }
            };
            return appTO;
        }

        private applicationTO attachDocuments(Application app, applicationTO appTO)
        {
            SolaDocService docService = new SolaDocService(username, password);
            var SourceList = new List<sourceTO>();
            foreach (var doc in app.Documents)
            {
                SourceList.Add(docService.makeSourceTO(doc.Content, doc.Extension, doc.Description, app.ContactPerson.getName));

            }
            appTO.sourceList = SourceList.ToArray();
            return appTO;
        }

        public Application getApplicationById(int Id)
        {
            return Context.Applications.Where(p => p.Id == Id).FirstOrDefault();
        }

        public applicationTO SubmitToSola()
        {
            var appTO = getAppTO();
            ICaseManagementService caseManagementService = CasemanagementProxy.Instance;
            caseManagementService.SetCredentials(username, password);

            var solaAppTO = caseManagementService.SaveApplication(appTO);
            return solaAppTO;
        }

        public string save()
        {
            Context.AddToApplications(app);
            Context.SaveChanges();
            return app.EntityKey.ToString();
        }
    }
}
