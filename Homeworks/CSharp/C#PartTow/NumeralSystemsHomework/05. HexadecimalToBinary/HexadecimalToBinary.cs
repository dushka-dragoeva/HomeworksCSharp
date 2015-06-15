using System;
using System.Linq;
using System.Text;

//Write a program to convert hexadecimal numbers to binary numbers (directly)
class HexadecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Enter hexadecimal number: ");
        string hex = Console.ReadLine();
        hex=hex.ToUpper();
        //string toBin = HexToBin(hex);
        Console.WriteLine("Converted to binary: {0}", HexToBin(hex) );
    }
    static string HexToBin(string hex)
    {
        //char[] hexChar = hex.ToUpper().ToCharArray();
        StringBuilder binaryStr = new StringBuilder();
        //for (int i = 0; i > hex.Length; i++)
        foreach(char digit in hex)
        {
            switch (digit)
            {
                case '0': binaryStr.Append(" 0000"); break;
                case '1': binaryStr.Append(" 0001"); break;
                case '2': binaryStr.Append(" 0010"); break;
                case '3': binaryStr.Append(" 0011"); break;
                case '4': binaryStr.Append(" 0100"); break;
                case '5': binaryStr.Append(" 0101"); break;
                case '6': binaryStr.Append(" 0110"); break;
                case '7': binaryStr.Append(" 0111"); break;
                case '8': binaryStr.Append(" 1000"); break;
                case '9': binaryStr.Append(" 1001"); break;
                case 'A': binaryStr.Append(" 1010"); break;
                case 'B': binaryStr.Append(" 1011"); break;
                case 'C': binaryStr.Append(" 1100"); break;
                case 'D': binaryStr.Append(" 1101"); break;
                case 'E': binaryStr.Append(" 1110"); break;
                case 'F': binaryStr.Append(" 1111"); break;
            }
        }
        return binaryStr.ToString();
    }
}