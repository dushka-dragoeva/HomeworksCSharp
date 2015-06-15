using System;
using System.Linq;

    class MaximalKSum
    {
        static void Main(string[] args)
        {

        //Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.


            Console.Write("Enter lenth N for the array  ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter M < N for sum  ");
            int m = int.Parse(Console.ReadLine());
            int[] newArr = new int[n];
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write("Enter element with index {0}  ", i);
                newArr[i] = int.Parse(Console.ReadLine());
            }
            
            int sum  = 0;
            Array.Sort(newArr);
            
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i]+", ");
            }
            Console.WriteLine();
            for (int i = newArr.Length-1; i >= newArr.Length-m; i--)
            {
                sum += newArr[i];
            }
            Console.WriteLine(sum);
        }
    }