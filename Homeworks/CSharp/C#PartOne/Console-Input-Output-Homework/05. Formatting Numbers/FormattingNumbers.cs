using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        //05. Write a program that reads 3 numbers:
        //integer a (0 <= a <= 500),floating-point b, loating-point c
        //The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        //The number a should be printed in hexadecimal, left aligned
        //Then the number a should be printed in binary form, padded with zeroes
        //The number b should be printed with 2 digits after the decimal point, right aligned
        //The number c should be printed with 3 digits after the decimal point, left aligned
        Thread.CurrentThread.CurrentCulture =
        CultureInfo.InvariantCulture;
        string text = "Please enter ";
        Console.Write(text + "a positive integer A <501: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write(text + "a real number B: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write(text + "a real number C: ");
        float c = float.Parse(Console.ReadLine());
        string binariA = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("{0,-10:X}|{1}|{2,10:0.02}|{3,-10:F3} ", a, binariA,b,c );
    }
}