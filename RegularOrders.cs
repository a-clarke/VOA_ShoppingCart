using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VOA_CheckoutApp.Orders;

namespace VOA_CheckoutApp
{
    class RegularOrders : IOrderDetails
    {
        public List<object> OrderDetails(int quantityOfApples, int quantityOfOranges, string location)
        {
            List<object> orderDetails = new List<object> { quantityOfApples, quantityOfOranges, location};

            return orderDetails;
        }

        public List<object> School()
        {
            //Quantity
            int apples = 500;
            int oranges = 500;

            //Location
            string location = "School";

            return OrderDetails(apples, oranges, location);
        }

        public List<object> Office()
        {
            //Quantity
            int apples = 750;
            int oranges = 500;

            //Location
            string location = "Office";

            return OrderDetails(apples, oranges, location);
        }

        public List<object> Factory()
        {
            //Quantity
            int apples = 300;
            int oranges = 300;

            //Location
            string location = "Factory";

            return OrderDetails(apples, oranges, location);
        }
    }
}
