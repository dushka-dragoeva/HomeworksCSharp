using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //09.Write a program that reads from the console a positive integer number n (1 = n = 20) 
            //and prints a matrix like in the examples below. Use two nested loops.

            Console.Write("Enter an integer n:  ");
            int n = int.Parse(Console.ReadLine());
            string text = "{0,2} ";
            for(int i =1;i<=n;i++)
            {
                
                Console.Write(text,i);
                for (int j = i+1; j <=(i+n-1);j++ )
                {
                    Console.Write(text,j);
                }
                Console.WriteLine();
                    
            }

        }
    }
}
