using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class viewDeal : BasePage{
    
    public Deal selectedDeal;

    protected void Page_Load(object sender, EventArgs e)
    {

        int dealID = Convert.ToInt16( Request.QueryString["dealID"]);

        selectedDeal = DealsController.getDealByDealID(dealID);

        TimeSpan time = (selectedDeal.ExpiresOn).Subtract(DateTime.Now);

        string format = "HH mm ss";

        Label1.Text = new DateTime((long)time.Ticks).ToString(format);

        List<Deal> list = new List<Deal>();
        list.Add(selectedDeal);

        Repeater1.DataSource = list;
        Repeater1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/purchase.aspx?dealID=" + selectedDeal.DealID);
    }
}