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
     
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
       
        
    }
}