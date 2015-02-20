using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
        //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
        //The output is like in the examples below
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("n = ");
        double n = double.Parse(Console.ReadLine());
        double number;
        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            number = double.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }

            sum += number;
        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:0.00}", sum / n);
    }
}