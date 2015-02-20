using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        //11.Write a program that reads two positive integer numbers and prints how many numbers p
        //exist between them such that the reminder of the division by 5 is 0.

        Console.Write("Please, enter first Positive Integer: ");
        uint first = uint.Parse(Console.ReadLine());
        Console.Write("Please, enter second Positive Integer: ");
        uint second = uint.Parse(Console.ReadLine());
        int counter = 0;
        for (uint i = Math.Min(first, second); i <= Math.Max(first, second); i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                Console.Write("{0}, ", i);
            }
        }
        Console.WriteLine("\nBetween {1} and {2} - {0} numbers are divided by 5 without reminder"
                            , counter, first, second);

    }
}