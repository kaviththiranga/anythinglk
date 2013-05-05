using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserController
/// </summary>
public class UserController
{
	public UserController()
	{
		//
		// TODO: Add constructor logic here
		//

        User user1 = new User();

        int x = user1.UserID;

        user1.UserID = 50;
	}
}