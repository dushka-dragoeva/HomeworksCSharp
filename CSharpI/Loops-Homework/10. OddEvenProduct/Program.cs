using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given n integers (given in a single line, separated by a space).
            //write a program that checks whether the product of the odd elements is equal to the product of the even elements.
            //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
            string numbers = Console.ReadLine();
            string[] array = numbers.Split(' ');
            int productOdd = 1;
            int productEven = 1;
            int counter = 1;

            foreach (var letter in array)
            {
                int num = int.Parse(letter.ToString());
                if (counter % 2 == 0)
                    productEven *= num;
                else
                    productOdd *= num;
                counter++;
            }
            if(productOdd == productEven)
            {
                Console.Write("yes -  product = " + productEven);
            }
            else
            {
                Console.WriteLine(" no - product odd = " + productOdd);
                Console.WriteLine("      product even = " + productEven);
            } 
            
        }
    }
}


