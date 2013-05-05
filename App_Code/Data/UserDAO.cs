using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for UserDAO
/// </summary>
public class UserDAO : AbstractDAO
{
    private DataTable userDataTable;

    // LINQ Query to get all records in the table
    private IEnumerable<User> allUsersQuery;

	public UserDAO()
	{
        allUsersQuery = from user in db.Users select user;

        userDataTable = AbstractDAO.LINQToDataTable<User>(allUsersQuery);

        isCacheValid = true;        
	}

    public DataTable getUserTable() 
    {
        if (!isCacheValid)
        {
            userDataTable = AbstractDAO.LINQToDataTable<User>(allUsersQuery);
        }
           
        return userDataTable;
    }

    public bool insertOrUpdate(User user) {

        // This is an update
        if (user.UserID > 0)
        {
            return submitChanges();
        }
        else {

            db.Users.InsertOnSubmit(user);

            return submitChanges();
        }


    }

    public bool deleteUser(User user) {

        db.Users.DeleteOnSubmit(user);

        return submitChanges();
    
    }

    public User getUserByUsername(String userName) {

        foreach (User user in allUsersQuery) { 
            
            if(user.Username.Equals(userName)){
                return user;
            }
        }

        return null;
    }

    public User getUserByEmail(String email)
    {

        foreach (User user in allUsersQuery)
        {

            if (user.Email.Equals(email))
            {
                return user;
            }
        }

        return null;
    }

}