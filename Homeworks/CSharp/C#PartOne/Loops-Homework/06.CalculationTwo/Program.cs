using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculationTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            //Use only one loop.

            Console.Write("Enter an integer n:  ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter an integer k:  ");
            double k = double.Parse(Console.ReadLine());
            double firstF = 1;
            double secondF = 1;
            
            for( double i =n;i>=1;i--)
            {
                firstF *= i;
                if (i <= k)
                secondF *= i;
            }
           
            Console.WriteLine("result {0}", firstF/secondF);


        }
    }
}
