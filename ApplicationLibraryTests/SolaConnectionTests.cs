using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.sola.services.boundary.wsclients;

namespace ApplicationLibraryTests
{
    [TestClass]
    public class SolaConnectionTests
    {
        [TestMethod]
        public void SolaCanConnect()
        {
            IAdministrativeService admin_svc = AdministrativeServiceProxy.Instance;
            admin_svc.SetCredentials(AppStore.username, AppStore.password);
            bool connection_status = admin_svc.CheckConnection();
            Assert.AreEqual(true, connection_status);
        }
    }
}
