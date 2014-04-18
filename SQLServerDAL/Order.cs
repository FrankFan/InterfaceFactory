using System;
using IDAL;

namespace SQLServerDAL
{
    public class Order:IOrder
    {
        string IOrder.GetOrder()
        {
            return "Order From SQLServer.";
        }
    }
}
