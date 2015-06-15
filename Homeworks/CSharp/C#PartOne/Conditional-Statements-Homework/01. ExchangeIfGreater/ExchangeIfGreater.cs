using System;
using System.Globalization;
using System.Threading;

    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            //01Write an if-statement that takes two double variables a and b and exchanges their 
            //values if the first one is greater than the second one. 
            //As a result print the values a and b, separated by a space.


            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter first number:  ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            double numberTow = double.Parse(Console.ReadLine());
            if (numberOne > numberTow)
            {
                double greaterNumber=numberOne;
                numberOne=numberTow;
                numberTow = greaterNumber;
            }
                Console.WriteLine("{0} {1}", numberOne,numberTow);
        }
    }

