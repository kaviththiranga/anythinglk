using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected override void InitializeCulture()
    {
        String language = (String)Session["UICulture"];
        
        if (language != null) {
        
            UICulture = language;
        }
        else if(Request.Form["language"] != null)
        {
            UICulture = Request["language"];
        }
        base.InitializeCulture();
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        InitializeCulture();
    }
}