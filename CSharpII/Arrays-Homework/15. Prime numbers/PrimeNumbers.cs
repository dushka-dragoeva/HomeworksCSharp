using System;
using System.Linq;
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());

        bool[] primeNumbers = new bool[n];
        for (int i = 2; i < primeNumbers.Length; i++)
        {
            primeNumbers[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(primeNumbers.Length); i++)
        {
            if (primeNumbers[i] == true)
            {
                for (int j = i * i; j < primeNumbers.Length; j = j+i)
                {
                    primeNumbers[j] = false;
                    
                }
            }
        }
        for (int i = 2; i < primeNumbers.Length; i++)
        {
            if (primeNumbers[i] == true)
                Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}
