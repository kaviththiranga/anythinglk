using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyWishList : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Repeater1.DataSource = DealsController.getWishList();
        Repeater1.DataBind();
    }
}