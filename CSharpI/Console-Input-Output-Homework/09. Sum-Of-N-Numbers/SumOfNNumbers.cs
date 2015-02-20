using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        //09 Write a program that enters a number n and after that enters more n numbers and 
        //calculates and prints their sum. Note: You may need to use a for-loop.

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please enter {0} numbers in a single line, \nseparated by a space:  ", number);
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