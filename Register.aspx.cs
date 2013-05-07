using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        Response.Redirect("Default.aspx");


    }

    [WebMethod]
    public static bool isEmailNotRegistered(string email) {

        return UserController.isEmailNotRegistered(email);
    }

}