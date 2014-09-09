using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : BasePage
{
    protected string returnUrl;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (UserController.isLoggedIn()) {

            Response.Redirect("~/userProfile.aspx");
            Session["AlertMsg"] = "Ooops! You are already registered.";
            Session["AlertMsgClass"] = "alert-info";
        }
        returnUrl = (string)Request.QueryString["return"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        User user = new User();

        user.FirstName = inputFirstName.Text;
        user.LastName = inputLastName.Text;
        user.Email = inputEmail.Text;
        user.Password = inputPassword.Text;
        user.Contact = inputContact.Text;

        UserController.save(user);

        Session["AlertMsg"] = "User successfully Registered. Please Sign in using ur credentials.";
        Session["AlertMsgClass"] = "alert-success";

        if (returnUrl == null || returnUrl.Equals(""))
        {
            Response.Redirect("Default.aspx");
        }

        Response.Redirect(returnUrl);

    }

    [WebMethod]
    public static bool isEmailNotRegistered(string email) {

        return UserController.isEmailNotRegistered(email);
    }

}