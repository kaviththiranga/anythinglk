using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class anything : System.Web.UI.MasterPage
{
    public int One { get; set; }  
    protected void Page_Load(object sender, EventArgs e)
    {
        
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
}
