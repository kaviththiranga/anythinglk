<%@ Application Language="C#" %>
<%@ Import Namespace="System.ComponentModel.DataAnnotations" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Web.DynamicData" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
//throw new Exception(ConfigurationManager.ConnectionStrings["anythinglkConnectionString"].ConnectionString);
        // Code that runs on application startup
        System.Data.SqlClient.SqlDependency.Start(ConfigurationManager.ConnectionStrings["anythinglkConnectionString"].ConnectionString);

        // Create an instance of the data model. 
        MetaModel DefaultModel = new MetaModel();
        // Register the data model. 
        DefaultModel.RegisterContext(typeof(
          DataClassesDataContext),
          new ContextConfiguration() { ScaffoldAllTables = true });

        // Create the routes.      
        RouteTable.Routes.Add(new
            DynamicDataRoute("{table}/{action}.aspx")
            {
                Constraints = new RouteValueDictionary(new
                {
                    action = "List|Details|Edit|Insert"
                }),
                Model = DefaultModel
            });
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
