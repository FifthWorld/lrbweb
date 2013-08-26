<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>
<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path="~/App_Themes/SiteTheme/bootstrap/js/jquery.js",
            DebugPath = "~/App_Themes/SiteTheme/bootstrap/js/jquery.js"
        });
        //RegisterRoutes(System.Web.Routing.RouteTable.Routes);
    }

    public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
    {
        routes.MapPageRoute("default", "", "~/Default.aspx");
        
        routes.MapPageRoute("dashboard", "dashboard", "~/User/Default.aspx");
        routes.MapPageRoute("profile", "profile", "~/User/Profile.aspx");
        routes.MapPageRoute("applications", "applications", "~/User/Applications.aspx");
        routes.MapPageRoute("certificates", "certificates", "~/User/Certificates.aspx");
        
        routes.MapPageRoute("application", "application", "~/User/Forms/Default.aspx");
        routes.MapPageRoute("individual_application", "application/individual", "~/User/Forms/Individual.aspx");
        routes.MapPageRoute("corporate_application", "application/corporate", "~/User/Forms/CorporateForm.aspx");
        routes.MapPageRoute("error", "error", "~/User/Forms/Error.aspx");
        routes.MapPageRoute("success", "success", "~/User/Forms/Success.aspx");
        
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
