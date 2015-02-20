using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        //07.Write a program that enters 5 numbers (given in a single line, separated by a space), 
        //calculates and prints their sum

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please,Enter 5 numbers in a single line, separated by a space:  ");
        string strNumbers = Console.ReadLine();
        double sum = 0;
        string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < Numbers.Length; i++)
        {
            sum += double.Parse(Numbers[i]);
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}