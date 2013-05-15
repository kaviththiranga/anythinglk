using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DealDAO
/// </summary>
public class DealDAO : AbstractDAO
{
	private DataTable dealDataTable;

    // LINQ Query to get all records in the table
    private IEnumerable<Deal> allDealsQuery;

    private List<Deal> dealsList;

    public DealDAO()
	{
        dealsList = new List<Deal>();
        allDealsQuery = from deal in db.Deals orderby deal.PlacedOn descending select deal;

        dealDataTable = AbstractDAO.LINQToDataTable<Deal>(allDealsQuery);

        initList();
        isCacheValid = true;        
	}

    private void initList() {

        foreach (Deal deal in allDealsQuery) {

            dealsList.Add(deal);
        }
    }

    public DataTable getUserTable() 
    {
        if (!isCacheValid)
        {
            dealDataTable = AbstractDAO.LINQToDataTable<Deal>(allDealsQuery);
            initList();
        }
           
        return dealDataTable;
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

        foreach (Deal deal in allDealsQuery) {

            if (deal.DealID.Equals(dealID))
            {
                return deal;
            }
        }

        return null;
    }

    public List<Deal> getDealsByCat(int catID)
    {
        initList();
        List<Deal> set = new List<Deal>();

        foreach (Deal d in dealsList) {

            if (d.CatID == catID)
            {
            
                set.Add(d);
            }
        }
        return set;
    }

    public List<Deal> getDealsByCat(int catID, int count)
    {
        initList();
        List<Deal> set = new List<Deal>();

        foreach (Deal d in dealsList)
        {

            if (d.CatID == catID)
            {

                set.Add(d);
            }

            if (set.Count == count) {
                break;
            }
        }
        return set;
    }
}