<%@ WebHandler Language="C#" Class="AjaxUploadHandler" %>

using System;
using System.Web;
using System.IO;
using ApplicationLibrary;
using ApplicationLibrary.Data;
using System.Web.SessionState;
using System.Drawing.Imaging;

public class AjaxUploadHandler : IHttpHandler,IRequiresSessionState {

    public void ProcessRequest(HttpContext context)
    {
        if (context.Request.Files.Count > 0)
        {
            var data1 = context.Request.Form["devLevyReciepts"];
            var data2 = context.Request.Form["surveyPlan"];
            
            string path = context.Server.MapPath("Temp");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            
            var file = context.Request.Files[0];
            string filename = Path.Combine(path, file.FileName);
            file.SaveAs(filename);
            
            
            context.Response.ContentType = "text/plain";
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var result = new { name = file.FileName };
            //var result = new { name = data1.ToString() };
            if (data1 != null && data2==null)
            {
                context.Session["desc"] = serializer.Serialize(data1.ToString());
            }
            else if (data2 != null && data1==null)
            {
                context.Session["desc"] = serializer.Serialize(data2.ToString()); 
            }
            context.Session["name"] = file.FileName;
            context.Session["type"]=file.ContentType;
            context.Session["path"]=filename;
            context.Response.Write(serializer.Serialize(result));
            //context.Response.Write(data1.ToString());
            #region Upload document to database
            //var variable = context.Request.Form[""];
            #endregion
        }
    }
 
    public bool IsReusable {
        get {
            return true;
        }
    }

}