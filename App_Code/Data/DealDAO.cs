using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Threading;

public class DealDAO : AbstractDAO
{
    // LINQ Query to get all records in the table
    private IEnumerable<Deal> allDealsQuery;

    private SqlCacheDependency dependency;

    private CacheInfo cacheInfo;

    public DealDAO()
	{
        dependency = new SqlCacheDependency("anythinglk", "Deals");
        allDealsQuery = from deal in db.Deals orderby deal.PlacedOn descending select deal;
        cacheInfo = new CacheInfo();

        HttpContext.Current.Cache.Insert("CacheValid", cacheInfo, dependency);
               
	}

    public void Reload()
    {
        db.Refresh(RefreshMode.OverwriteCurrentValues, allDealsQuery);
        HttpContext.Current.Cache.Insert("CacheValid", cacheInfo, dependency);
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

    public Deal getDealByDealID(int dealID) {

        if (HttpContext.Current.Cache["CacheValid"] == null)
        {
            Reload();
        }
        foreach (Deal deal in allDealsQuery)
        {

            if (deal.DealID == dealID)
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

        if (HttpContext.Current.Cache["CacheValid"] == null)
        {
            Reload();
            //Thread.Sleep(12000);
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

public class CacheInfo
{

    public String IsValid { get; set; }
}