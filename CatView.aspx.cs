using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CatView :BasePage
{
    protected int catID;
 
    protected void Page_Load(object sender, EventArgs e)
    {
        catID = Convert.ToInt16( Request.QueryString["catID"]);

    }
}