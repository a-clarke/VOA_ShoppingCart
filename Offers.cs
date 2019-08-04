using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class Offers
    {
        public decimal BuyOneGetOneFree(Calculator calculator, decimal totalCost)
        {
            var offerPrice = calculator.DivideByTwo(totalCost);

            return offerPrice;
        }

        public decimal ThreeForTwo(Calculator calculator, decimal totalCost)
        {
            var thirdOfCost = calculator.DivideByThree(totalCost);
            var twoThirdsOfCost = calculator.Subtraction(totalCost, thirdOfCost);

            return twoThirdsOfCost;
        }
    }
}
