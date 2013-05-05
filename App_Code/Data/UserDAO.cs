using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for UserDAO
/// </summary>
public class UserDAO
{

    private static DataClassesDataContext db = new DataClassesDataContext();

    private static DataSet userdataset = new DataSet();

	public UserDAO()
	{
		//
		// TODO: Add constructor logic here
		//

        IEnumerable<User> result = from user in db.Users where user.UserID == 1 select user;
        
        
	}
}