using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        //01. Write an expression that checks if given integer is odd or even
        
        Console.Write("Please enter an integer   ");
        int number = int.Parse(Console.ReadLine());
        bool result = (number % 2 == 1);

        
        Console.WriteLine("The number {0} is odd - {1} ", number, result);
    }
}