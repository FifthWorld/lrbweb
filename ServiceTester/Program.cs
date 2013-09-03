using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.sola.services.boundary.wsclients;
using org.sola.webservices.administrative.extra;
using org.sola.webservices.casemanagement.extra;
using org.sola.webservices.filestreaming;
using org.sola.webservices.search.extra;

namespace ServiceTester
{
    public class ko { public static void observable() { } }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting tests..."); 
            IAdministrativeService administrativeService = AdministrativeServiceProxy.Instance;
            administrativeService.SetCredentials("test", "test");
            Console.WriteLine("AdministrativeService.CheckConnection = " + administrativeService.CheckConnection());
            //baUnitTO baUnit = administrativeService.GetBaUnitById("2965019"); // Valid BA Unit Id required!!
            //if (baUnit != null)
            //{
            //    Console.WriteLine("AdministrativeService.GetBaUnitById = " + baUnit.nameFirstpart + "/" + baUnit.nameLastpart + " - " + baUnit.rowVersion);
            
            //    // To test the save you need to provide a service id that is referenced by a pending transaction.transaction
            //    //baUnit.nameFirstpart = "2";
            //    //baUnit = administrativeService.SaveBaUnit("26cf9f4e-8081-475e-831e-275967754c98", baUnit);
            //    //Console.WriteLine("AdministrativeService.SaveBaUnit = " + baUnit.nameFirstpart + "/" + baUnit.nameLastpart + " - " + baUnit.rowVersion);
            //}

            ISearchService searchService = SearchServiceProxy.Instance;
            searchService.SetCredentials("test", "test");
            Console.WriteLine("SearchService.CheckConnection = " + searchService.CheckConnection());
            userSearchResultTO[] activeUsers = searchService.GetActiveUsers();
            int size = activeUsers == null ? 0 : activeUsers.Length;
            Console.WriteLine("Num of Active Users = " + size);
            Console.WriteLine("*** Press enter to close ***");

            partyTO personalInfo;
            applicationPropertyTO property;
            applicationTO application;
            partyTO party = new partyTO();

            
            ICaseManagementService caseManagementService = CasemanagementProxy.Instance;
            caseManagementService.SetCredentials("test", "test");
            party.address = new addressTO() { description = "some desc" };
            party.age=10;
            party.dateOfBirth=DateTime.Now;
            party.dateOfBirthSpecified=true;
            party.email="e911miri@gmail.com";
            party.fathersLastName="Miriwa";
            party.fathersName="Wisdom";
            party.lastName="Tomiwa";
            party.mobile="07037290250";
            party.name="Tomiwa Ijaware";
            party.phone="07037290250";
            party.typeCode = "naturalPerson";
            partyTO p=caseManagementService.SaveParty(party);
            Console.WriteLine("PArty with ID "+p.id+ " has just been loaded");

            property = new applicationPropertyTO()
            {
                
            };
            

            applicationTO app2 = new applicationTO() { 
                contactPerson=party,
                serviceList = new serviceTO[]
                {
                    new serviceTO(){
                        requestTypeCode="newCofO",
                        actionCode="lodge",
                        statusCode="lodged",                        
                    }
                }
            };
            caseManagementService.SaveApplication(app2);
            Console.WriteLine("Application has been saved successfully");

            var app3 = caseManagementService.GetApplication(app2.id);
            
            Console.ReadKey();
        }
    }

}
