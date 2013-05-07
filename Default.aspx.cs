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
       GridView2.DataSource = UserController.getUserDataTable();
      GridView2.DataBind();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        User user = UserController.getUserByEmail("kaviththiranga@gmail.com");

       

        UserController.save(user);

        
        User user2 = new User();


        user2.Password = "dfdfdf";
        user2.Email = "dffffffff";

        UserController.save(user2);
        GridView2.DataSource = UserController.getUserDataTable();
       GridView2.DataBind();
        
    }
}