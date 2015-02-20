using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        //06. Write a program that finds the biggest of five numbers by using only five if statements.

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter first number  ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter second number  ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter third number  ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter first number  ");
        decimal fourthNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter second number  ");
        decimal fifthNumber = decimal.Parse(Console.ReadLine());
        decimal biggestNumber = firstNumber;
        if (secondNumber > biggestNumber)
        {
            biggestNumber = secondNumber;
        }
        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }
        if (fourthNumber > biggestNumber)
        {
            biggestNumber = fourthNumber;
        }
        if (fifthNumber > biggestNumber)
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine("The bigest number is:  " + biggestNumber);
    }
}