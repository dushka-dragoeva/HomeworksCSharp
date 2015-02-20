using System;

class PrimeNumberCheck
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n = 100) is prime 
        //(i.e. it is divisible without remainder only to itself and 1)
        // За да е просто числото се дели с остатак едновременно на 2,3,5 и 7
        Console.Write("Please enter positive integer number <= 100:  ");
        uint number = uint.Parse(Console.ReadLine());
        bool check = ((number % 2) != 0 && (number % 3) != 0 && (number % 5) != 0 && (number % 7) != 0);
        Console.WriteLine("This number {0} is prime -  {1} ",number, check);
        }
}