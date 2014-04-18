using System;
using IDAL;

namespace OracleDAL
{
    public class Order:IOrder
    {
        public string GetOrder()
        {
            return "Order From Oracle.";
        }
    }
}
