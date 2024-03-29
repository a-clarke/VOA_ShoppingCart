﻿using System;
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
            Offers offers = new Offers();

            //Global variables
            decimal costOfApples = 0;
            decimal costOfOranges = 0;
            List<decimal> schoolOutputList = new List<decimal>();
            List<decimal> officeOutputList = new List<decimal>();
            List<decimal> factoryOutputList = new List<decimal>();

            //School Order
            var schoolOrder = regularOrders.School();
            costOfApples = calculator.MultiplyTwoObjects(schoolOrder[0], fruit.Apple_Cost);
            costOfOranges = calculator.MultiplyTwoObjects(schoolOrder[1], fruit.Orange_Cost);
            schoolOutputList.Add(costOfApples);
            schoolOutputList.Add(costOfOranges);
            var schoolApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, schoolOrder[2].ToString(), schoolOutputList[0].ToString(), false);
            var schoolOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, schoolOrder[2].ToString(), schoolOutputList[1].ToString(), false);

            //Discounted School Order
            var discountedCostOfApples = offers.BuyOneGetOneFree(calculator, costOfApples);
            var discountedCostOfOranges = offers.ThreeForTwo(calculator, costOfOranges);
            schoolOutputList.Add(discountedCostOfApples);
            schoolOutputList.Add(discountedCostOfOranges);
            var discountedSchoolApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, schoolOrder[2].ToString(), schoolOutputList[2].ToString(), true);
            var discountedSchoolOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, schoolOrder[2].ToString(), schoolOutputList[3].ToString(), true);


            //Office Order
            var officeOrder = regularOrders.Office();
            costOfApples = calculator.MultiplyTwoObjects(officeOrder[0], fruit.Apple_Cost);
            costOfOranges = calculator.MultiplyTwoObjects(officeOrder[1], fruit.Orange_Cost);
            officeOutputList.Add(costOfApples);
            officeOutputList.Add(costOfOranges);
            var officeApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, officeOrder[2].ToString(), officeOutputList[0].ToString(), false);
            var officeOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, officeOrder[2].ToString(), officeOutputList[1].ToString(), false);

            //Discounted Office Order
            discountedCostOfApples = offers.BuyOneGetOneFree(calculator, costOfApples);
            discountedCostOfOranges = offers.ThreeForTwo(calculator, costOfOranges);
            officeOutputList.Add(discountedCostOfApples);
            officeOutputList.Add(discountedCostOfOranges);
            var discountedOfficeApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, officeOrder[2].ToString(), officeOutputList[2].ToString(), true);
            var discountedOfficeOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, officeOrder[2].ToString(), officeOutputList[3].ToString(), true);


            //Factory Order
            var factoryOrder = regularOrders.Factory();
            costOfApples = calculator.MultiplyTwoObjects(factoryOrder[0], fruit.Apple_Cost);
            costOfOranges = calculator.MultiplyTwoObjects(factoryOrder[1], fruit.Orange_Cost);
            factoryOutputList.Add(costOfApples);
            factoryOutputList.Add(costOfOranges);
            var factoryApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, factoryOrder[2].ToString(), factoryOutputList[0].ToString(), false);
            var factoryOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, factoryOrder[2].ToString(), factoryOutputList[1].ToString(), false);

            //Discounted Factory Order
            discountedCostOfApples = offers.BuyOneGetOneFree(calculator, costOfApples);
            discountedCostOfOranges = offers.ThreeForTwo(calculator, costOfOranges);
            factoryOutputList.Add(discountedCostOfApples);
            factoryOutputList.Add(discountedCostOfOranges);
            var discountedFactoryApplesOutput = consoleOutput.OrderInformation(fruit.Apple_Label, officeOrder[2].ToString(), factoryOutputList[2].ToString(), true);
            var discountedFactoryOrangesOutput = consoleOutput.OrderInformation(fruit.Orange_Label, officeOrder[2].ToString(), factoryOutputList[3].ToString(), true);


            //Bills custom order
            var billsOrder = customOrders.BillsOrder(fruit, false);
            var billsOrderOutput = consoleOutput.OrderInformation(billsOrder[0], billsOrder[1], billsOrder[2], false);

            //Bills discounted order
            var billsDiscountedOrder = customOrders.BillsOrder(fruit, true);
            var billsDiscountedOrderOutput = consoleOutput.OrderInformation(billsDiscountedOrder[0], billsDiscountedOrder[1], billsDiscountedOrder[2], true);

            Console.WriteLine(schoolApplesOutput);
            Console.WriteLine(schoolOrangesOutput);
            Console.WriteLine(officeApplesOutput);
            Console.WriteLine(officeOrangesOutput);
            Console.WriteLine(factoryApplesOutput);
            Console.WriteLine(factoryOrangesOutput);
            Console.WriteLine(billsOrderOutput);
            Console.WriteLine("Press Enter to find out about the stores new offers!");
            Console.ReadLine();

            Console.WriteLine("Shop announces two new offers:");
            Console.WriteLine("Buy one get one free on Apples.");
            Console.WriteLine("3 for the price of 2 on Oranges.");
            Console.WriteLine("To see how this effects the checkout totals, press Enter!");
            Console.ReadLine();
            

            Console.WriteLine(discountedSchoolApplesOutput);
            Console.WriteLine(discountedSchoolOrangesOutput);
            Console.WriteLine(discountedOfficeApplesOutput);
            Console.WriteLine(discountedOfficeOrangesOutput);
            Console.WriteLine(discountedFactoryApplesOutput);
            Console.WriteLine(discountedFactoryOrangesOutput);
            Console.WriteLine(billsDiscountedOrderOutput);
            Console.ReadLine();





        }
    }
}
