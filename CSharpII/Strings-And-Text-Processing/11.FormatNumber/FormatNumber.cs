using System;
using System.Globalization;
using System.Threading;
using System.Text;

/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/

class FormatNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,15:F2}",number);
        if(number<0)
        {
            StringBuilder negHex = new StringBuilder();
            negHex.Append('-');
            string hex=Math.Abs((int)number).ToString("X");
            negHex.Append(hex);
            Console.WriteLine("{0,15}",negHex);
        }
        else
        {
            Console.WriteLine("{0,15:X}", (int)number);
        }
        Console.WriteLine("{0,15:P}", number/100);
        Console.WriteLine("{0,15:E}", number);
    }
}