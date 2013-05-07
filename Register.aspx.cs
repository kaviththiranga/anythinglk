using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        User user = new User();

        user.FirstName = inputFirstName.Text;
        user.LastName = inputLastName.Text;
        user.Username = inputUsername.Text;
        user.Email = inputEmail.Text;
        user.Password = inputPassword.Text;
        user.Contact = inputContact.Text;

        UserController.save(user);
    }

    [WebMethod]
    public static bool isUsernameAvailable(string username) {

       return UserController.isUsernameAvailable(username);
       
    }

}