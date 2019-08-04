using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class CustomOrders
    {

        public List<string> BillsOrder(Fruit fruit)
        {
            decimal totalCost = 0m;
            string orderType = "Apples and Oranges";
            string customer = "Bill";

            string apple = fruit.Apple_Label;
            string orange = fruit.Orange_Label;
            decimal costOfApple = fruit.Apple_Cost;
            decimal costOfOrange = fruit.Orange_Cost;

            //Bill wants 4 apples and 2 oranges this week
            //Order received in the following format - as item name only
            List<string> billsShoppingList = new List<string> {apple, apple, apple, apple, orange, orange };

            foreach(string item in billsShoppingList)
            {
                if(item == "apple")
                {
                    totalCost = totalCost + costOfApple;
                }
                else
                {
                    totalCost = totalCost + costOfOrange;
                }
            }

            List<string> billsBill = new List<string>();
            billsBill.Add(orderType.ToString());
            billsBill.Add(customer.ToString());
            billsBill.Add(totalCost.ToString());

            return billsBill;
        }
    }
}
