using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDAO
/// </summary>
public class OrderDAO : AbstractDAO
{
    private DataTable orderDataTable;

    // LINQ Query to get all records in the table
    private IEnumerable<Order> allOrdersQuery;

	public OrderDAO()
	{
        allOrdersQuery = from order in db.Orders select order;

        orderDataTable = AbstractDAO.LINQToDataTable<Order>(allOrdersQuery);

        isCacheValid = true;     
	}

    public DataTable getDealsTable()
    {
        if (!isCacheValid)
        {
            orderDataTable = AbstractDAO.LINQToDataTable<Order>(allOrdersQuery);
        }

        return orderDataTable;
    }

    public bool insertOrUpdate(Order order)
    {

        // This is an update
        if (order.OrderID > 0)
        {
            return submitChanges();
        }
        else
        {

            db.Orders.InsertOnSubmit(order);

            return submitChanges();
        }


    }

    public bool deleteOrder(Order order)
    {

        db.Orders.DeleteOnSubmit(order);

        return submitChanges();

    }

    public Order getOrderByOrderID(String orderID)
    {

        foreach (Order order in allOrdersQuery)
        {

            if (order.OrderID.Equals(orderID))
            {
                return order;
            }
        }

        return null;
    }

    public List<Order> getOrdersByUserID(string userID) {

        List<Order> result = new List<Order>();

        foreach (Order order in allOrdersQuery)
        {

            if (order.UserID.Equals(userID))
            {
                result.Add(order);
            }
        }

        return result;
    }

}