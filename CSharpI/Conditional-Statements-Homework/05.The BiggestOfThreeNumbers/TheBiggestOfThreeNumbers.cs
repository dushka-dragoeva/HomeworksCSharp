using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfThreeNumbers
{
    static void Main(string[] args)
    {
        //05. Write a program that finds the biggest of three numbers 

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter first number  ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter second number  ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter third number  ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter first number  ");
        decimal biggestNumber = firstNumber;
        if (secondNumber > biggestNumber)
        {
            biggestNumber = secondNumber;
        }
        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }
        Console.WriteLine("The bigest number is:  " + biggestNumber);
    }
}