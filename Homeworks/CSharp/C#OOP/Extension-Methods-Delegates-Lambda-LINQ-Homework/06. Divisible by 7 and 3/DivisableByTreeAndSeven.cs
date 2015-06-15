/*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
  Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/
namespace _06.Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DivisableByTreeAndSeven
    {
        static void Main()
        {
            int[] myArray = { 77, 33, 7, 9, -42, 156, 782, 14, 28, -121, 21 };

            var divisibleTreeAndSevenLambda = myArray.Where(x => (x % 3 == 0 && x % 7 == 0))
                .ToArray();
            Console.WriteLine(string.Join(", ", divisibleTreeAndSevenLambda));
            Console.WriteLine();
            var divisibleTreeAndSevenLinq =
                                    from number in myArray
                                    where (number % 3 == 0 && number % 7 == 0)
                                    select number;
            foreach (var number in divisibleTreeAndSevenLinq)
            {
                Console.WriteLine(number);
            }
        }
    }
}

