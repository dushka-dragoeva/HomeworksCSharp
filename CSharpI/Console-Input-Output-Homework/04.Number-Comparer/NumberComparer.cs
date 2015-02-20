using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main(string[] args)
    {
        //04.Write a program that gets two numbers from the console and prints the greater of them.
        //Try to implement this without if statements.
        Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture;
        Console.Write("Please, enter firt number:  ");
        double firstNumber = double.Parse (Console.ReadLine());
        Console.Write("Please, enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        //По-голямото от двете числа можете да намерите с функцията Math.Max(a, b), 
        //а по-малкото с Math.Min(a, b).
        Console.WriteLine("The greater number is:  " + Math.Max(firstNumber,secondNumber));
    }
}