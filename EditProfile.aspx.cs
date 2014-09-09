using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditProfile : BasePage
{
    protected User currentUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!UserController.isLoggedIn()) {
            Session["AlertMsg"] = "Error. Please login first.";
            Session["AlertMsgClass"] = "alert-error";
            Response.Redirect("~/Default.aspx");
        }

        currentUser = UserController.getCurrentUser();

        if (!Page.IsPostBack)
        {
            inputFirstName.Text = currentUser.FirstName;
            inputLastName.Text = currentUser.LastName;
            inputContact.Text = currentUser.Contact;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!inputPassword.Text.Equals("")) {
            currentUser.Password = inputPassword.Text;
        }

        currentUser.FirstName=inputFirstName.Text;
        currentUser.LastName=inputLastName.Text ;
        currentUser.Contact=inputContact.Text ;
        UserController.save(currentUser);

        Session["AlertMsg"] = "Successfully saved";
        Session["AlertMsgClass"] = "alert-success";
    }
}