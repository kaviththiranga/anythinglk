﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

/// <summary>
/// Summary description for AbstractDAO
/// </summary>
public class AbstractDAO
{
    protected static DataClassesDataContext db;

    protected bool isCacheValid;

    static AbstractDAO() {
        db = new DataClassesDataContext();
    }
	public AbstractDAO()
	{
        
        isCacheValid = false;
	}

    public static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
    {
        DataTable dtReturn = new DataTable();

        // column names 
        PropertyInfo[] oProps = null;

        if (varlist == null) return dtReturn;

        foreach (T rec in varlist)
        {


            if (oProps == null)
            {
                oProps = ((Type)rec.GetType()).GetProperties();
                foreach (PropertyInfo pi in oProps)
                {
                    Type colType = pi.PropertyType;

                    if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                    == typeof(Nullable<>)))
                    {
                        colType = colType.GetGenericArguments()[0];
                    }

                    dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                }
            }

            DataRow dr = dtReturn.NewRow();

            foreach (PropertyInfo pi in oProps)
            {
                dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                (rec, null);
            }

            dtReturn.Rows.Add(dr);
        }
        return dtReturn;
    }

    protected bool submitChanges()
    {
        try
        {
            db.SubmitChanges();
            isCacheValid = false;
            return true;
        }
        catch (Exception e)
        {
            Exception ex2 = e;
            while (ex2.InnerException != null)
            {
                ex2 = ex2.InnerException;
            }
            Console.WriteLine(e.InnerException);
            throw;
            /*Console.WriteLine(e.StackTrace.ToString());
            return false;*/
        }
    }
}