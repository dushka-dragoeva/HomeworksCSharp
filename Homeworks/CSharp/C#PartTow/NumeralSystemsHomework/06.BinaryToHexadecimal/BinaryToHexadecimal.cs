using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program to convert binary numbers to hexadecimal numbers (directly)
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:  ");
        string number = Console.ReadLine();
        Console.WriteLine("Decimal is " + BinToHex (number));
    }
    static string BinToHex(string bin)
    {
        int strLength = bin.Length;
        int temp = 4-bin.Length % 4;
        if (temp!=0)
        {
            for (int i=0;i<temp;i++)
            {
                bin = '0' + bin;
            }
        }

        StringBuilder binStr = new StringBuilder();

        for (int i = 0; i < strLength; i = i + 4)
        {
            switch (bin.Substring(i, 4))
            {
                case "0000": binStr.Append('0'); break;
                case "0001": binStr.Append('1'); break;
                case "0010": binStr.Append('2'); break;
                case "0011": binStr.Append('3'); break;
                case "0100": binStr.Append('4'); break;
                case "0101": binStr.Append('5'); break;
                case "0110": binStr.Append('6'); break;
                case "0111": binStr.Append('7'); break;
                case "1000": binStr.Append('8'); break;
                case "1001": binStr.Append('9'); break;
                case "1010": binStr.Append('A'); break;
                case "1011": binStr.Append('B'); break;
                case "1100": binStr.Append('C'); break;
                case "1101": binStr.Append('D'); break;
                case "1110": binStr.Append('E'); break;
                case "1111": binStr.Append('F'); break;
            }
        }
        return binStr.ToString();
    }
}