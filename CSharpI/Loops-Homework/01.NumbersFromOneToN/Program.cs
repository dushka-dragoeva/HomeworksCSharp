using System;

class NumbersFromOneToN
{
    static void Main(string[] args)
    {
        //Write a program that enters from the console a positive integer n and prints 
        //all the numbers from 1 to n, on a single line, separated by a space.

        Console.Write("Please, enter a positive integer n:  ");
        int n = int.Parse(Console.ReadLine());
        int num = 0;
        while (num < +n)
        {
            num++;
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}

