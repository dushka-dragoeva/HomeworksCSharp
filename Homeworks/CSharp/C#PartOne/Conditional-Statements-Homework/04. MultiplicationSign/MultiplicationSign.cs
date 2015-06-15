using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        //04. Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        //Use a sequence of if operators.

        Thread.CurrentThread.CurrentCulture =
                CultureInfo.InvariantCulture;
        Console.Write("Please enter first number  ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter second number  ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter third number  ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        int count = 0;
        string sign = " ";

        if (firstNumber<0)
        {
            count++;
        }
        if(secondNumber<0)
        {
            count++;
        }
        if (thirdNumber<0)
        {
            count++;
        }
        if ((count++) % 2 == 1)
        {
            sign = "-";
        }
        else sign = "+";
        if (firstNumber==0||secondNumber==0||thirdNumber==0)
        {
            sign = "0";
        }
        Console.WriteLine("Result " + sign);


    }
}

