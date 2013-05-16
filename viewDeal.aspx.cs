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

        List<Deal> list = new List<Deal>();
        list.Add(selectedDeal);

        Repeater1.DataSource = list;
        Repeater1.DataBind();
    }
}