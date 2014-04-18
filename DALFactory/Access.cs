using System;
using IDAL;

namespace DALFactory
{
    public class Access
    {
        public static IOrder CreateOrder()
        {
            SQLServerDAL.Order order = new SQLServerDAL.Order();
            return (IOrder)order;
        }
    }
}
