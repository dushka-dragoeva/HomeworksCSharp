
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

class SolveTasks
{
    static void Main()
    {
        /*•	Write a program that can solve these tasks:
            o	Reverses the digits of a number
            o	Calculates the average of a sequence of integers
            o	Solves a linear equation a * x + b = 0
          •	Create appropriate methods.
          •	Provide a simple text-based menu for the user to choose which task to solve.
          •	Validate the input data:
            o	The decimal number should be non-negative
            o	The sequence should not be empty
            o	a should not be equal to 0*/

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string userChoice = "0";
        while (userChoice == "0")
        {
            Console.WriteLine(" \n              Program options: \n");
            Console.WriteLine("   1) Reverses the digits of a number");
            Console.WriteLine("   2) Calculates the average of a sequence of integers");
            Console.WriteLine("   3) Solves a linear equation 'a * x + b = 0'");

            Console.Write("\nEnter your choice: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1": ReverseDigitsOfNumber(); return;
                case "2": AverageSumOfSequence(); return;
                case "3": SolveLinearEquation(); return;
                default:
                    Console.Clear();
                    userChoice = "0";
                    break;
            }
        }
    }
    static void ReverseDigitsOfNumber()
    {
        decimal number = 0;
        do
        {
            Console.Write("Enter a positive number (real or integer): ");
            number = decimal.Parse(Console.ReadLine());
        }
        while (number < 0);

        decimal result = decimal.Parse(new string(number.ToString()
                                .ToCharArray()
                                .Reverse()
                                .ToArray()));
        Console.WriteLine(" \n The reversed number is:  " + result + "\n");
    }
    static void AverageSumOfSequence()
    {
        int n = 0;
        do
        {
            Console.Write("Enter a positive integer N (size of array): ");
            n = int.Parse(Console.ReadLine());
        }
        while (n <= 0);
        int[] numbers = new int[n];
        Console.WriteLine("\nEnter a {0} integers to array: ", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n The avarage is: " + numbers.Average() + "\n");
    }
    static void  SolveLinearEquation()
    {
        decimal a = 0;

        do
        {
            Console.Write("Enter a non-zero number A: ");
            a = decimal.Parse(Console.ReadLine());
        }
        while (a == 0);

        Console.Write("Enter a number B: ");
        decimal b = decimal.Parse(Console.ReadLine()); 
        decimal x = b/a;
        Console.WriteLine("\n X = {0} \n", x);
    }
}
