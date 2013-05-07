using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserController
/// </summary>
public class UserController
{
    private static UserDAO userDAO;

	static UserController()
	{
        userDAO = new UserDAO();
	}
    public static bool authenticate(string email, string password) {

        User user = userDAO.getUserByEmail(email);

        if (user != null && user.Password.Equals(password)) {

            HttpContext.Current.Session["CurrentUser"] = user;

            return true;
        }

        return false;
    }

    public static void logout() {

        HttpContext.Current.Session["CurrentUser"] = null;
    }

    public static User getCurrentUser() {

        return (User)HttpContext.Current.Session["CurrentUser"];
    }

    public static bool isLoggedIn() {
        if (getCurrentUser() != null) {
            return true;
        }
        return false;
    }
    public static DataTable getUserDataTable() {

        return userDAO.getUserTable();
    }

    public static User getUserByEmail(String email)
    {
        return userDAO.getUserByEmail(email);
    }

    public static void save(User user) {

        userDAO.insertOrUpdate(user);
    }

    public static bool isEmailNotRegistered(string email)
    {

        if (getUserByEmail(email) == null)
        {
            return true;
        }

        return false;
    }
}