using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class ConsoleOutput
    {
        public string OrderInformation(string fruit, string location, string cost)
        {
            string orderDescription = $"Cost of {fruit} for {location} is {cost}";

            return orderDescription;
        }
    }
}
