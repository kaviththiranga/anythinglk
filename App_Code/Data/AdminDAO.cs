using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Caching;

/// <summary>
/// Summary description for UserDAO
/// </summary>
public class AdminDAO : AbstractDAO
{
    private DataTable adminDataTable;

    // LINQ Query to get all records in the table
    private IEnumerable<Administrator> allAdminQuery;

    private SqlCacheDependency sqlDpendency;

    public AdminDAO()
	{
        allAdminQuery = from admin in db.Administrators select admin;

        adminDataTable = AbstractDAO.LINQToDataTable<Administrator>(allAdminQuery);

        isCacheValid = true;
	}

    public DataTable getAdminUserTable() 
    {
        if (!isCacheValid)
        {
            adminDataTable = AbstractDAO.LINQToDataTable<Administrator>(allAdminQuery);
        }

        return adminDataTable;
    }

    public bool insertOrUpdate(Administrator admin)
    {

        // This is an update
        if (admin.UserID > 0)
        {
            return submitChanges();
        }
        else {

            db.Administrators.InsertOnSubmit(admin);

            return submitChanges();
        }


    }

    public bool deleteAdministrator(Administrator admin)
    {

        db.Administrators.DeleteOnSubmit(admin);

        return submitChanges();
    
    }

    public Administrator getAdminByEmail(String email)
    {

        foreach (Administrator admin in allAdminQuery)
        {

            if (admin.User.Email.Equals(email))
            {
                return admin;
            }
        }

        return null;
    }

}