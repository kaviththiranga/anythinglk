<%@ Application Language="C#" %>
<%@ Import Namespace="System.ComponentModel.DataAnnotations" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Web.DynamicData" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {

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
                    action = "List|Details|Edit|Insert|ProfileDetails"
                }),
                Model = DefaultModel
            });
    }
    
    void Application_End(object sender, EventArgs e) 
    {
       
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        

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
