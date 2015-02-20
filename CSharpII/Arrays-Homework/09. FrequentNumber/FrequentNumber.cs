using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FrequentNumber
{
    static void Main()
    {
        //Write a program that finds the most frequent number in an array.
        //Example:

        //input	                                        result
        //4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	        4 (5 times)


        //Console.Write("Enter integers seperated with comma:  ");
        //string input = Console.ReadLine();
        string input = "4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3";
        int[] newArr = input
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();

        Array.Sort(newArr);
        int lenth = 1;
        int bestSeq = 0;
        int bestLenth = 1;
        for (int i = 0; i < newArr.Length - 1; i++)
        {
            if (newArr[i] == newArr[i + 1])
            {
                lenth++;
            }
            else
            {
                lenth = 1;
            }
            if (lenth >= bestLenth)
            {
                bestLenth = lenth;
                bestSeq = newArr[i];
            }
        }
        Console.WriteLine("{0} ({1} times) ", bestSeq, bestLenth);
    }
}