using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert binary numbers to their decimal representation.
class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter binary number:  ");
        string number = Console.ReadLine();
        Console.WriteLine("Decimal is "+BinaryDecimal(number));
    }

    static long BinaryDecimal(string bynaryNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < bynaryNumber.Length;i++ )
        {
            int digit = bynaryNumber[i] - '0';
            int position =bynaryNumber.Length-i-1;
            decimalNumber += digit * (long)Math.Pow(2, position);
        }
            return decimalNumber;
    }
}



