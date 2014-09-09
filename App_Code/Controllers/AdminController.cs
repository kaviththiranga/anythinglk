using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AdminController
/// </summary>
public class AdminController
{
    static AdminDAO adminDAO = new AdminDAO();
	static AdminController()
	{

	}

    public static bool authenticate(string email, string password)
    {

        Administrator admin = adminDAO.getAdminByEmail(email);

        if (admin != null && admin.User.Password.Equals(password))
        {

            HttpContext.Current.Session["CurrentAdmin"] = admin;

            return true;
        }

        return false;
    }

    public static bool isAdmin() {

        if (HttpContext.Current.Session["CurrentAdmin"] != null && HttpContext.Current.Session["CurrentAdmin"] is Administrator)
        {
            return true;
        }

        return false;
    }

    public static Administrator getCurrentAdmin() {

        return (Administrator)HttpContext.Current.Session["CurrentAdmin"];
    
    }

    public static void logout()
    {

        HttpContext.Current.Session["CurrentAdmin"] = null;
    }


}