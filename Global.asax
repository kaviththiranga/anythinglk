<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
//throw new Exception(ConfigurationManager.ConnectionStrings["anythinglkConnectionString"].ConnectionString);
        // Code that runs on application startup
        System.Data.SqlClient.SqlDependency.Start(ConfigurationManager.ConnectionStrings["anythinglkConnectionString"].ConnectionString);
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        System.Data.SqlClient.SqlDependency.Stop(ConfigurationManager.ConnectionStrings["anythinglkConnectionString"].ConnectionString);
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
