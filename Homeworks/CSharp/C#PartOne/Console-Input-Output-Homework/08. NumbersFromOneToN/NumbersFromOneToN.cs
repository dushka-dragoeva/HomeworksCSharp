using System;
using System.Globalization;
using System.Threading;

class NumbersFromOneToN
{
    static void Main()
    {
        //08. Write a program that reads an integer number n from the console and prints all 
        //the numbers in the interval [1..n], each on a single line.

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
