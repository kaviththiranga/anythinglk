using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : BasePage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        DailyDRepeater.DataSource = DealsController.getDealsByCat(1, 5);
        DailyDRepeater.DataBind();

        Repeater1.DataSource = DealsController.getDealsByCat(3, 5);
        Repeater1.DataBind();
        Repeater2.DataSource = DealsController.getDealsByCat(4, 5);
        Repeater2.DataBind();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
       
        
    }
}