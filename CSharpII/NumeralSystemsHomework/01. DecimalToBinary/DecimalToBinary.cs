using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer:  ");
        long number = long.Parse(Console.ReadLine());
        DecimalBimnary(number);
    }
    static void DecimalBimnary(long decimalToBinary)
    {
        byte[] BinaryNumber = new byte[64];
        if (decimalToBinary < 0)
        {
            BinaryNumber[0] = 1;
            decimalToBinary = Math.Abs(decimalToBinary);
        }
        for (int i = BinaryNumber.Length - 1; i > 0; i--)
        {
            if (decimalToBinary == 0)
            {
                break;
            }
            else
            {
                BinaryNumber[i] = Convert.ToByte(decimalToBinary % 2);
                decimalToBinary = decimalToBinary / 2;
            }
        }
        Console.WriteLine(string.Join("", BinaryNumber));
    }
}

