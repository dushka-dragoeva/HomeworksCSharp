using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        //10. Write a program that reads a number n and prints on the console the first  members 
        //of the Fibonacci sequence (at a single line, separated by comma and space - ,) 
        //: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

        Console.Write("Please enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        decimal firstMember = 0m;
        decimal secondMember = 1m;
        decimal sum;
        for (int i = 0; i < number; i++)
        {
            Console.Write("{0}, ", firstMember);
            sum = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = sum;
        }
    }
}