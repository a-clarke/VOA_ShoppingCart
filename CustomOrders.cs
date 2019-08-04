using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class CustomOrders
    {

        public List<string> BillsOrder(Fruit fruit, bool discountApplied)
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

            if (discountApplied == true)
            {
                Offers offers = new Offers();
                Calculator calculator = new Calculator();
                var costOfApples = 0m;
                var costOfOranges = 0m;

                foreach (string item in billsShoppingList)
                {
                    if (item == "Apple(s)")
                    {
                        costOfApples = costOfApples + costOfApple;
                    }
                    else
                    {
                        costOfOranges = costOfOranges + costOfOrange;
                    }
                }

                var discountedCostOfApples = offers.BuyOneGetOneFree(calculator, costOfApples);
                var discountedCostOfOranges = offers.ThreeForTwo(calculator, costOfOranges);
                totalCost = discountedCostOfApples + discountedCostOfOranges;

            }
            else
            {
                foreach (string item in billsShoppingList)
                {
                    if (item == "Apple(s)")
                    {
                        totalCost = totalCost + costOfApple;
                    }
                    else
                    {
                        totalCost = totalCost + costOfOrange;
                    }
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
