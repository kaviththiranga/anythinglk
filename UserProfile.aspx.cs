﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserProfile : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["logout"] != null && UserController.isLoggedIn()) {

            Session["AlertMsg"] = "Successfully Logged Out. Bye " + UserController.getCurrentUser().FirstName + " " + UserController.getCurrentUser().LastName + "! ";
            Session["AlertMsgClass"] = "alert-success";

            UserController.logout();
            Response.Redirect("Default.aspx");
        }
    }

}