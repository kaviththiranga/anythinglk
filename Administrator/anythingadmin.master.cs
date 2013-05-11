using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Administrator_anythingadmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SigninButtonModal_Click(object sender, EventArgs e)
    {
        if (AdminController.authenticate(inputEmailModal.Text, inputPasswordModal.Text))
        {
            Session["AlertMsg"] = "Administrator Successfully Logged in. Welcome " + AdminController.getCurrentAdmin().User.FirstName + " " + AdminController.getCurrentAdmin().User.LastName + "! ";
            Session["AlertMsgClass"] = "alert-success";
            Response.Redirect(Request.RawUrl);
        }

        Session["AlertMsg"] = "Error. Check your Administrator credentials and try again.";
        Session["AlertMsgClass"] = "alert-error";
    }
}
