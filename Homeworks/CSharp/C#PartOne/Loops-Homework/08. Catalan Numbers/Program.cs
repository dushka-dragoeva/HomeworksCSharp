using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 08. Write a program to calculate the nth Catalan number =(2n)!/((n+1)!*n!   by given n (1 <= n <= 100).
            Console.Write("Enter an integer n:  ");
            double n = double.Parse(Console.ReadLine());
    
            double firstF = 1;//2n
            double secondF = 1;//(n+1)
            double thirdF = 1;//n

            for (double i = 2*n; i >= 1; i--)
            {
                firstF *= i;
                if (i <= (n+1))
                {
                    secondF *= i;
                }
                if (i <= n)
                {
                    thirdF *= i;
                }
            }
            double result = firstF / (secondF * thirdF);
            Console.WriteLine("result {0}", result);
        }
    }
}
