using System;
using System.Collections.Generic;
using System.Linq;

//Write a program to convert decimal numbers to their binary representation.

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer:  ");
        long number = long.Parse(Console.ReadLine());
        DecimalToHexa(number);
    }
    static void DecimalToHexa(long decimalToHexa)
    {
        string hexStr = string.Empty;
        bool negative = false;
        if (decimalToHexa < 0)
        {
            decimalToHexa = Math.Abs(decimalToHexa);
            negative = true;
        } while (decimalToHexa > 0)
        {
            var digit = (decimalToHexa % 16);
            if (digit >= 0 && digit < 10)
            {
                hexStr = (char)(digit + '0') +hexStr;
            }
            else
            {
                hexStr = (char)(digit - 10 + 'A') + hexStr;
            }
            decimalToHexa = decimalToHexa / 16;
        }
        if (negative)
        {
            hexStr = "-" + hexStr;
        }
        Console.WriteLine(hexStr);
    }
}