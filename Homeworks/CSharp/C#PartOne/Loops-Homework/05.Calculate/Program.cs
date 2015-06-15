using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {

            //05.Write a program that, for a given two integer numbers n and x, 
            //calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            //Use only one loop. Print the result with 5 digits after the decimal point

            Console.Write("Enter an integer n:  ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter an integer x:  ");
            double x =double.Parse(Console.ReadLine());
            double factorial =1;
            double sum = 1;
           
            for (int i=1;i<=n;i++)
            {
                factorial *= i;
                sum += factorial/Math.Pow(x,i);
            }
            Console.WriteLine("Sum = {0:F5}",sum);
        }

    }
}
