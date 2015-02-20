using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers1_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

            Console.Write("Please, enter a positive integer n:  ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(rand.Next(1, n + 1) + " ");
            } 
        }
    }
}
