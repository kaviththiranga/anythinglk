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

    public static DataTable getUserDataTable() {

        return userDAO.getUserTable();
    }
}