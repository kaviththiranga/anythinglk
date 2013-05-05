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

    private IEnumerable<Deal> allDealsQuery;

    public DealDAO()
	{
        allDealsQuery = from deal in db.Deals select deal;

        dealDataTable = AbstractDAO.LINQToDataTable<Deal>(allDealsQuery);

        isCacheValid = true;        
	}

    public DataTable getUserTable() 
    {
        if (!isCacheValid)
        {
            dealDataTable = AbstractDAO.LINQToDataTable<Deal>(allDealsQuery);
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

    public bool deleteUser(User user) {

        db.Users.DeleteOnSubmit(user);

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

}