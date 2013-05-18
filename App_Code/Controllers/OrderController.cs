using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderController
/// </summary>
public class OrderController
{
    static OrderDAO dao;

    static OrderController() {
        dao = new OrderDAO();
    }

    public static bool insertOrUpdate(Order order)
    {
        return dao.insertOrUpdate(order);
    }

    public static List<Order> getOrdersByUser(User user) {

        return dao.getOrdersByUserID(user.UserID);
    }

}