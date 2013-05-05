using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : BasePage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView2.DataSource = UserController.getUserDataTable();
        GridView2.DataBind();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        User user = UserController.getUserByEmail("kaviththiranga@gmail.com");

        user.Username = "pubudi";

        UserController.save(user);
        GridView2.DataSource = UserController.getUserDataTable();
        GridView2.DataBind();
        
    }
}