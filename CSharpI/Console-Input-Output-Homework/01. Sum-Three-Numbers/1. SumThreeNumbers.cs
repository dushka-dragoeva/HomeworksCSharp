using System;
using System.Globalization;
using System.Threading;

class SumThreeNumbers
{
    static void Main(string[] args)
    {
        //01. Write a program that reads 3 real numbers from the console and prints their sum.

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter first number:  ");
        double numberOne = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        double numberTow = double.Parse(Console.ReadLine());
        Console.Write("Please enter third number:  ");
        double numberThree = double.Parse(Console.ReadLine());
        double sum =numberOne+numberTow+numberThree;
        Console.WriteLine ("The sum of your numbers is: "+sum);
    }
}