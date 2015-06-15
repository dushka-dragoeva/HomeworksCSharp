using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

﻿//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigit
{
    static void Main(string[] args)
    {

        Thread.CurrentThread.CurrentCulture =
                CultureInfo.InvariantCulture;
        
        Console.Write("Enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.Write("Reversed: ");
        decimal reversed = ReverseDecimal(number);
        Console.WriteLine(reversed);
    }
    static decimal ReverseDecimal(decimal number)
        
    {
        decimal result =decimal.Parse(new string(number.ToString()
                        .ToCharArray()
                        .Reverse()
                        .ToArray()));
        return result;
    }
}