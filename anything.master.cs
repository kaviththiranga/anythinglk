﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class anything : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<String> themeList = new List<string>() ;

        if (!Page.IsPostBack) {
            themeList.Add("Select Theme...");
            themeList.Add("Cyborg");
            themeList.Add("Amelia");
            themeList.Add("Slate");
            themeList.Add("Cerulean");
            themeList.Add("simplex");
            themeList.Add("Readable");
            themeList.Add("Journal");
            themeList.Add("SpaceLab");
            themeList.Add("Spruce");
            themeList.Add("SuperHero");
            themeList.Add("United");
            themeList.Add("Cosmo");
            

            ThemeDropDown.DataSource = themeList;
            ThemeDropDown.DataBind();
        }
       
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Session["UICulture"] = "si";
        Response.Redirect(Request.RawUrl);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["UICulture"] = "ta";
        Response.Redirect(Request.RawUrl);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["UICulture"] = "en";
        Response.Redirect(Request.RawUrl);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Signin_Click(object sender, EventArgs e)
    {
        if (UserController.authenticate(inputEmailModal.Text, inputPasswordModal.Text)) {
            Session["AlertMsg"] = "Successfully Logged in. Welcome "+ UserController.getCurrentUser().FirstName+" "+UserController.getCurrentUser().LastName+"! ";
            Session["AlertMsgClass"] = "alert-success";
            Response.Redirect(Request.RawUrl);
        }

        Session["AlertMsg"] = "Error. Check your credentials and try again.";
        Session["AlertMsgClass"] = "alert-error";
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Session["AlertMsg"] = "Successfully Logged Out. Bye " + UserController.getCurrentUser().FirstName + " " + UserController.getCurrentUser().LastName + "! ";
        Session["AlertMsgClass"] = "alert-success";

        UserController.logout();
        Response.Redirect("Default.aspx");
    }

    protected void ThemeDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Theme"] = ThemeDropDown.SelectedValue;
        Response.Redirect(Request.RawUrl);
    }
    protected void ForgotPassword_Click(object sender, EventArgs e)
    {
        if(!inputEmailModal.Text.Equals("")){
            Session["AlertMsg"] = "Check your email for password reset link. Thank you.";
            Session["AlertMsgClass"] = "alert-success";

            //Send an email to user with password token
        }


    }
}
