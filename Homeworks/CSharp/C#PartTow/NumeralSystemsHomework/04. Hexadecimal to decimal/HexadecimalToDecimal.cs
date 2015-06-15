using System;
using System.Collections.Generic;
using System.Linq;
//Write a program to convert hexadecimal numbers to their decimal representation.
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:  ");
        string number = Console.ReadLine();
        number = number.ToUpper();
        Console.WriteLine("Decimal is " + HexadecimalDecimal(number));
    }
    static long HexadecimalDecimal(string hexaNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < hexaNumber.Length; i++)
        {
            int digit = 0;
            int position = hexaNumber.Length - i - 1;
            if (hexaNumber[i] >= '0' && hexaNumber[i] <= '9')
            {
                digit = hexaNumber[i] - '0';
            }
            else if (hexaNumber[i] >= 'A' && hexaNumber[i] <= 'F')
            {
                digit = hexaNumber[i] - 'A' +10;
            }
            decimalNumber += digit * (long)Math.Pow(16, position);
        }
        return decimalNumber;
    }
}