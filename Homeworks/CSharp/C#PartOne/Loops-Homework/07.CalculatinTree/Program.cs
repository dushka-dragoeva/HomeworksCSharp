using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculatinTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //07. In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            //(also known as the number of combinations) is calculated by the formula
            //there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loop
            
            Console.Write("Enter an integer n:  ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter an integer k:  ");
            double k = double.Parse(Console.ReadLine());
            double firstF = 1;
            double secondF = 1;
            double thirdF = 1;
             
            for (double i = n; i >= 1; i--)
            {
                firstF *= i;
                if (i <= k)
                {
                    secondF *= i;
                }
                if (i<=(n-k))
                {
                    thirdF *= i;
                }
            }

            //for (double j = (n-k); j >= 1; j--)
           // {

            //    thirdF *= j;
           // }
           double result=firstF/(secondF * thirdF);
            Console.WriteLine("result {0}", result);

        }
    }
}
