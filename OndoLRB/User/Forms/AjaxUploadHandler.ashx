<%@ WebHandler Language="C#" Class="AjaxUploadHandler" %>

using System;
using System.Web;
using System.IO;
using ApplicationLibrary;
using ApplicationLibrary.Data;
using System.Web.SessionState;
using System.Drawing.Imaging;
using System.Web.Security;

public class AjaxUploadHandler : IHttpHandler,IRequiresSessionState {

    public void ProcessRequest(HttpContext context)
    {
        if (context.Request.Files.Count > 0)
        {
            String data;
            int? appId;
            var file = context.Request.Files[0];
            
            if (context.Request.Form["devLevyReciepts"] != null)
            {
                data= context.Request.Form["devLevyReciepts"];
            }
            else if (context.Request.Form["surveyPlan"]  != null)
            {
                data = context.Request.Form["surveyPlan"];
            }
            else
            {
                data = null;
            }
                        
            try
            {
                 appId= int.Parse(context.Session["appId"].ToString());
            }
            catch (Exception ex)
            {
                appId = null;
            }
            
            if (null != appId)
            {                
                saveDocument(appId.Value, data, file);

                // INFO: Preparing the data that is returned by this request
                context.Response.ContentType = "text/plain";
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                var result = new
                {
                    name = file.FileName,
                    type = data
                };

                context.Response.Write(serializer.Serialize(result));
            }            
        }
    }

    public void saveDocument(int appId, string document_type, HttpPostedFile file)
    {
        MembershipUser user;
        SolaApplicationService appSvc = new SolaApplicationService(appId);
        var app = appSvc.app;
        
        MemoryStream mstream = new MemoryStream();
        file.InputStream.CopyTo(mstream);
        app.Documents.Add(new Document()
        {
            Content= mstream.ToArray(),
            Description=file.FileName,
            Extension= file.ContentType,
            DocumentType = document_type
        });
        
    }
 
    public bool IsReusable {
        get {
            return true;
        }
    }

}