using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOA_CheckoutApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add references
            Fruit fruit = new Fruit();
            RegularOrders regularOrders = new RegularOrders();
            CustomOrders customOrders = new CustomOrders();
            Calculator calculator = new Calculator();
            ConsoleOutput consoleOutput = new ConsoleOutput();

            //Global variables
            decimal costOfApples = 0;
            decimal costOfOranges = 0;
            List<decimal> outputList = new List<decimal>();

            //School Order
            var schoolOrder = regularOrders.School();
            costOfApples = calculator.MultiplyTwoObjects(schoolOrder[0], fruit.Apple_Cost);
            costOfOranges = calculator.MultiplyTwoObjects(schoolOrder[1], fruit.Orange_Cost);
            outputList.Add(costOfApples);
            outputList.Add(costOfOranges);
            var schoolApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, schoolOrder[2].ToString(), outputList[0].ToString());
            var schoolOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, schoolOrder[2].ToString(), outputList[1].ToString());

            //Office Order
            var officeOrder = regularOrders.Office();
            costOfApples = calculator.MultiplyTwoObjects(officeOrder[0], fruit.Apple_Cost);
            costOfOranges = calculator.MultiplyTwoObjects(officeOrder[1], fruit.Orange_Cost);
            outputList.Add(costOfApples);
            outputList.Add(costOfOranges);
            var officeApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, officeOrder[2].ToString(), outputList[2].ToString());
            var officeOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, officeOrder[2].ToString(), outputList[3].ToString());

            //Factory Order
            var factoryOrder = regularOrders.Factory();
            costOfApples = calculator.MultiplyTwoObjects(factoryOrder[0], fruit.Apple_Cost);
            costOfOranges = calculator.MultiplyTwoObjects(factoryOrder[1], fruit.Orange_Cost);
            outputList.Add(costOfApples);
            outputList.Add(costOfOranges);
            var factoryApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, factoryOrder[2].ToString(), outputList[4].ToString());
            var factoryOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, factoryOrder[2].ToString(), outputList[5].ToString());

            //Bills custom order
            var billsOrder = customOrders.BillsOrder(fruit);
            var billsOrderOutput = consoleOutput.OrderInformation(billsOrder[0], billsOrder[1], billsOrder[2]);

            Console.WriteLine(schoolApplesOutput);
            Console.WriteLine(schoolOrangesOutput);
            Console.WriteLine(officeApplesOutput);
            Console.WriteLine(officeOrangesOutput);
            Console.WriteLine(factoryApplesOutput);
            Console.WriteLine(factoryOrangesOutput);
            Console.WriteLine(billsOrderOutput);
            Console.ReadLine();


            


        }
    }
}
