using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class purchase : BasePage
{
    protected Deal purchasingDeal;

    protected void Page_Load(object sender, EventArgs e)
    {
        int deaID = Convert.ToInt16( Request.QueryString["dealID"]);

        purchasingDeal = DealsController.getDealByDealID(deaID);

        if (!Page.IsPostBack)
        {
            List<int> num = new List<int>();

            for (int i = 1; i < purchasingDeal.NoOfVouchers; i++)
            {
                num.Add(i);
            }
            inputQty.DataSource = num;
            inputQty.DataBind();
            total.Text = purchasingDeal.DiscountedPrice.ToString();
        }

        total.Text = "Rs. "+ (purchasingDeal.DiscountedPrice * Convert.ToInt16(inputQty.SelectedValue)).ToString("N2") +"/-";

    }
    protected void inputQty_TextChanged(object sender, EventArgs e)
    {
        total.Text = "Rs. " + (purchasingDeal.DiscountedPrice * Convert.ToInt16(inputQty.SelectedValue)).ToString("N2") + "/-";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}