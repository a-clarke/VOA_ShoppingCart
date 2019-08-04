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

        public decimal DivideByTwo(decimal cost)
        {
            var answer = cost / 2;

            return answer;
        }

        public decimal DivideByThree(decimal cost)
        {
            var answer = cost / 3;
            var rounderAnswer = Math.Round(answer, 2, MidpointRounding.AwayFromZero);

            return answer;
        }

        public decimal Subtraction(decimal totalCost, decimal cost)
        {
            var answer = totalCost - cost;

            return answer;
        }
    }
}
