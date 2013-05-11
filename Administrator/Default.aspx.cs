using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["logout"] != null && AdminController.isAdmin())
        {

            Session["AlertMsg"] = "Successfully Logged Out. Bye " + AdminController.getCurrentAdmin().User.FirstName + " " + AdminController.getCurrentAdmin().User.LastName + "! ";
            Session["AlertMsgClass"] = "alert-success";

            AdminController.logout();
            Response.Redirect("Default.aspx");
        }
    }
}