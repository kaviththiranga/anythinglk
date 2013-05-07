using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Caching;

/// <summary>
/// Summary description for UserDAO
/// </summary>
public class UserDAO : AbstractDAO
{
    private DataTable userDataTable;

    // LINQ Query to get all records in the table
    private IEnumerable<User> allUsersQuery;

    private SqlCacheDependency sqlDpendency;

	public UserDAO()
	{
        allUsersQuery = from user in db.Users select user;

        userDataTable = AbstractDAO.LINQToDataTable<User>(allUsersQuery);

        //sqlDpendency = new SqlCacheDependency("anythinglk", "Users");

       // HttpContext.Current.Cache.Insert("UserTable", userDataTable, sqlDpendency);

        isCacheValid = true;
        Console.WriteLine("Dao constructor");
	}

    public DataTable getUserTable() 
    {
        /*if (HttpContext.Current.Cache["UserTable"] == null)
        {
            userDataTable = AbstractDAO.LINQToDataTable<User>(allUsersQuery);

            HttpContext.Current.Cache.Insert("UserTable", userDataTable, sqlDpendency);
            Console.WriteLine("Get from database");
        }
        else {
            Console.WriteLine("Get from cache");
        }

        return (DataTable) HttpContext.Current.Cache["UserTable"];*/

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