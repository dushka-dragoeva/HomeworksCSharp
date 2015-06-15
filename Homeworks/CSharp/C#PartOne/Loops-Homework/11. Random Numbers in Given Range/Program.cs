using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters 3 integers n, min and max (min != max) 
            //and prints n random numbers in the range [min...max].


            Console.Write("Please, enter a positive integer n:  ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a positive integer min:  ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a positive integer max:  ");
            int max = int.Parse(Console.ReadLine());

            
            
            
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(rand.Next(min, max + 1) + " ");
            } 

        }
    }
}
