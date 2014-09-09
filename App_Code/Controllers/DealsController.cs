using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DealsController
/// </summary>
public class DealsController
{
    private static DealDAO dao;

	static DealsController()
	{
        dao = new DealDAO();
	}

    public static List<Deal> getDealsByCat(int catID)
    {

        return dao.getDealsByCat(catID);
    }

    public static List<Deal> getDealsByCat(int catID, int count)
    {
        return dao.getDealsByCat(catID, count);
    }

    public static Deal getDealByDealID(int dealID)
    {
        return dao.getDealByDealID(dealID);
    }

    public static bool saveWishListItem(WishList item) {
        return dao.insertOrUpdate(item);
    }

    public static List<Deal> getWishList()
    {

        if (UserController.isLoggedIn()) {

           return dao.getWishList(UserController.getCurrentUser());
        }
        return null;
    }
}
