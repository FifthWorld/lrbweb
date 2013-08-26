using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationLibrary.Data;
using ApplicationLibrary;
using System.Data;

namespace ApplicationLibraryTests
{
    [TestClass]
    public class ApplicationTests
    {
        
        [TestMethod]
        public void Test_Save_Application()
        {
            SolaApplicationService SolaAppSvc = new SolaApplicationService();
            Application app = SolaAppSvc.app;

            app.UserId = "e911miri";
            app.ContactPerson.DOB = DateTime.Today;
            app.ContactPerson.Email = "e911miri@gmail.com";

            app.Properties.Add(new Property()
            {
                Developed = false,
                LandUse = "Cultivating of Home grown Cashew Trees"
            });

            //Application is still detached in this case
            Assert.AreEqual(app.EntityState, EntityState.Detached);
            SolaAppSvc.save();

            //Application should have an entity key
            Assert.IsNotNull(app.EntityKey);

            //Application should have an unchanged state after save
            Assert.AreEqual(app.EntityState, EntityState.Unchanged);

            //Application should exist in the database
            Assert.IsNotNull(SolaAppSvc.getApplicationById(app.Id));

            //Application Id should not be changed during the save process
            Assert.AreEqual(app.Id, SolaAppSvc.getApplicationById(app.Id).Id);

            //The Application should have a contact person
            Assert.IsNotNull(app.ContactPerson);

            //There should be only one party and one property attached to this application
            Assert.IsTrue(app.Parties.Count == 1);
            Assert.IsTrue(app.Properties.Count == 1);
        }


        [TestMethod]
        public void SubmitApplicationToSola()
        {
            Application app = new Application();
            app.StartDate = DateTime.Now;
            app.UserId = "e911miri";
            app.ContactPerson.Email="e911miri@gmail.com";
            app.ContactPerson.DOB = DateTime.Today;

            app.Properties.Add(new Property()
            {
                Developed = false,
                LandUse = "Smoking"
            });
            app.SubmissionDate = DateTime.Now;

            SolaApplicationService SolaAppSvc = new SolaApplicationService();
            SolaAppSvc.app = app;
            SolaAppSvc.save();
            Assert.IsNotNull(SolaAppSvc.getApplicationById(app.Id));
            Assert.AreEqual(app.Id, SolaAppSvc.getApplicationById(app.Id).Id);

            var appTO = SolaAppSvc.SubmitToSola();
            Assert.IsNotNull(appTO);
        }

    }
}
