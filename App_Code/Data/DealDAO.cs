using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;

public class DealDAO : AbstractDAO
{
    // LINQ Query to get all records in the table
    private IEnumerable<Deal> allDealsQuery;

    private SqlCacheDependency dependency;


    public DealDAO()
	{
        dependency = new SqlCacheDependency("anythinglk", "Deals");
        allDealsQuery = from deal in db.Deals orderby deal.PlacedOn descending select deal;

        HttpContext.Current.Cache.Insert("CacheValid", new Deal(), dependency);
        Reload();
               
	}

    public void Reload()
    {
        db.Refresh(RefreshMode.OverwriteCurrentValues, allDealsQuery);
    }

    public DataTable getUserTable() 
    {
        if (HttpContext.Current.Cache["CacheValid"] == null)
        {
            Reload();
        }
        return AbstractDAO.LINQToDataTable<Deal>(allDealsQuery);       
    }

    public bool insertOrUpdate(Deal deal)
    {

        // This is an update
        if (deal.DealID > 0)
        {
            return submitChanges();
        }
        else {

            db.Deals.InsertOnSubmit(deal);

            return submitChanges();
        }


    }

    public bool deleteDeal(Deal deal) {

        db.Deals.DeleteOnSubmit(deal);

        return submitChanges();
    
    }

    public Deal getDealByDealID(String dealID) {

        if (HttpContext.Current.Cache["CacheValid"] == null)
        {
            Reload();
        }
        foreach (Deal deal in allDealsQuery)
        {

            if (deal.DealID.Equals(dealID))
            {
                return deal;
            }
        }

        return null;
    }

    public List<Deal> getDealsByCat(int catID)
    {
        List<Deal> set = new List<Deal>();

        if (HttpContext.Current.Cache["CacheValid"] == null)
        {
            Reload();
        }
        foreach (Deal deal in allDealsQuery)
        {

            if (deal.CatID == catID)
            {

                set.Add(deal);
            }
        }
        return set;
    }

    public List<Deal> getDealsByCat(int catID, int count)
    {
        List<Deal> set = new List<Deal>();

        if (HttpContext.Current.Cache["CacheValid"] == null) {
            Reload();
        }
        foreach (Deal deal in allDealsQuery)
        {

            if (deal.CatID == catID)
            {

                set.Add(deal);
            }

            if (set.Count == count)
            {
                break;
            }
        }        
        
        return set;
    }
}