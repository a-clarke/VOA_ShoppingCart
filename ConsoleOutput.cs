using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class ConsoleOutput
    {
        public string OrderInformation(string fruit, string location, string cost, bool discount)
        {
            string orderDescription = "";

            if(discount == false)
            {
                orderDescription = $"Cost of {fruit} for {location} is {cost}";
            }
            else
            {
                orderDescription = $"Discounted cost of {fruit} for {location} is {cost}";
            }

            return orderDescription;
        }
    }
}
