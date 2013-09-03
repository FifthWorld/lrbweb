using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationLibrary;

namespace ApplicationLibraryTests
{
    [TestClass]
    public class ApplicationPartyTests
    {
        [TestMethod]
        public void Save_Without_Contact_Person()
        {
            SolaApplicationService appSvc = new SolaApplicationService();
            appSvc.app.UserId = "1324";
            appSvc.save();
            Assert.AreEqual(appSvc.app.Status, "Incomplete");
            Assert.IsFalse(appSvc.isComplete());
        }

        [TestMethod]
        public void Submit_Without_User_Application()
        {
            SolaApplicationService appSvc = new SolaApplicationService();
            appSvc.SubmitToSola();
            Assert.AreEqual(appSvc.app.Status, "No User");
            Assert.IsNull(appSvc.app.SolaId);
            Assert.IsFalse(appSvc.isComplete());
        }
    }
}
