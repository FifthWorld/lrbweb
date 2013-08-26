using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ApplicationLibrary;
using org.sola.webservices.digitalarchive.extra;

namespace ApplicationLibraryTests
{
    [TestClass]
    public class DocumentsTests
    {
        [TestMethod]
        public void sendDocumentToSola()
        {
            
        }

        //[TestMethod]
        //public void uploadDocument()
        //{
        //    MemoryStream mstream = new MemoryStream();
        //    Stream stream = File.Open("Documents/word.docx", FileMode.Open, FileAccess.Read);
        //    FileInfo fileInfo = new FileInfo("Documents/word.docx");
        //    stream.CopyTo(mstream);

        //    string fileName = "";
        //    SolaDocService docSvc = new SolaDocService();
        //    fileName = docSvc.UploadDocument(mstream.ToArray());
        //    Assert.AreNotSame(fileName, "");

        //}

        //[TestMethod]
        //public void digitizeUploadedDocument()
        //{
        //    MemoryStream mstream = new MemoryStream();
        //    Stream stream = File.Open("Documents/word.docx", FileMode.Open, FileAccess.Read);
        //    FileInfo fileInfo = new FileInfo("Documents/word.docx");
        //    stream.CopyTo(mstream);

        //    string fileName = "";
        //    SolaDocService docSvc = new SolaDocService(AppStore.username, AppStore.password);
        //    fileName = docSvc.UploadDocument(mstream.ToArray());

        //    documentBinaryTO response;
        //    response = docSvc.digitizeDocument(fileName, fileInfo.Extension, fileName);
        //    Assert.IsNotNull(response);
        //}
    }
}
