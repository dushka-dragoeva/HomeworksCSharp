using System;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present).
        //Example:

        //array	                    S        result
        //4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5


        //Console.Write("Enter integers seperated with comma:  ");
        //string input = Console.ReadLine();
        //Console.Write(" Enter sum  ");
        //int givenSum = int.Parse(Console.ReadLine());

        string input = "4, 3,  1, 4, 2, 5, 8";
        int[] newArr = input
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        int givenSum = 11;

        int currentSum = 0;
        int startIndex = 0;
        bool present = false;

        for (int i = 0; i < newArr.Length - 1; i++)
        {
            currentSum += newArr[i];
            startIndex = i;
            for (int j = i + 1; j < newArr.Length; j++)
            {
                currentSum += newArr[j];
                if (currentSum == givenSum)
                {
                    present = true;
                    for (int k = startIndex; k <= j; k++)
                    {
                        Console.Write("{0}, ", newArr[k]);
                    }
                    Console.WriteLine();
                    break;
                }
                else if(currentSum>givenSum)
                {
                    break;
                }
            }
            currentSum = 0;
        }
        if (present == false)
        {
            Console.WriteLine("There is no sum {0} ", givenSum);
        }
    }
}