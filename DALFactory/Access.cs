using System;
using System.Configuration;
using System.Reflection;
using IDAL;

namespace DALFactory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class Access
    {
        public static readonly string path = ConfigurationManager.AppSettings["DAL"];
        //ConfigurationSettings.AppSettings["DAL"]; //这种写法已过时
        //使用ConfigurationManager需要引入System.Configuration.dll

        public static IOrder CreateOrder()
        {
            //SQLServerDAL.Order order = new SQLServerDAL.Order();
            //return (IOrder)order;

            //改进一下,使用反射动态加载类
            string className = path + ".Order";
            return (IOrder)Assembly.Load(path).CreateInstance(className);


        }
    }
}
