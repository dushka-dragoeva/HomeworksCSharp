using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Binary_to_Decimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {

       //Using loops write a program that converts a binary integer number to its decimal form.
        //The input is entered as string. The output should be a variable of type long.
        //Do not use the built-in .NET functionality.

            Console.Write("Enter binary number: ");
            string str = Console.ReadLine();
            long result = 0;

            for (int i = (str.Length) - 1; i >= 0; i--)
            {
                result += long.Parse(str[str.Length - i - 1].ToString()) * (long)Math.Pow(2, i);
            }

            Console.WriteLine("Result: " + result);

        }
    }
}
