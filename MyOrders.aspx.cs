﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyOrders : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (UserController.isLoggedIn()) {
            GridView1.DataSource = OrderController.getOrdersOfCurrentUser();
            GridView1.DataBind();
        }
    }
}