using System;
using IDAL;
using DALFactory;


namespace Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IOrder order = Access.CreateOrder();
            Response.Write(order.GetOrder());
        }
    }
}