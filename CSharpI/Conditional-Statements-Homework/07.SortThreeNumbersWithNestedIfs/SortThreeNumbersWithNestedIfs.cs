using System;
using System.Globalization;
using System.Threading;

class SortThreeNumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        //07. Write a program that enters 3 real numbers and prints them sorted in descending order.
        //Use nested if statements.

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter first number  ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter second number  ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter third number  ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter first number  ");
        decimal first;
        decimal second;
        decimal third;

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            first = firstNumber;
            if (secondNumber > thirdNumber)
            {
                second = secondNumber;
                third = thirdNumber;
            }
            else
            {
                second = thirdNumber;
                third = secondNumber;
            }
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            first = secondNumber;

            if (firstNumber > thirdNumber)
            {
                second = firstNumber;
                third = thirdNumber;
            }
            else
            {
                second = thirdNumber;
                third = firstNumber;
            }
        }
        else
        {
            first = thirdNumber;
            if (firstNumber > secondNumber)
            {
                second = firstNumber;
                third = secondNumber;
            }
            else
            {
                second = secondNumber;
                third = firstNumber;
            }
        }
        Console.WriteLine(first + " " + second + " " + third);
    }
}