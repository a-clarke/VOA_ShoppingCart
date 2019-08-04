using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    public class Calculator
    {
        public decimal MultiplyTwoObjects(object quantity, decimal cost)
        {
            var answer = Convert.ToInt32(quantity) * cost;

            return answer;
        }
    }
}
