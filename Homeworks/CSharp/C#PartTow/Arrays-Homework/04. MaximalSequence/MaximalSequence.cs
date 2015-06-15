using System;
using System.Linq;
using System.Data.Linq;
class MaximalSequence
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
        //input	                            result
        //2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

        //Console.Write("Enter integers seperated with comma:  ");
        //string input = Console.ReadLine();
        string input = "2, 1, 1, 2, 3, 3, 2, 2, 2, 1";
        int[] newArr = input
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)) .ToArray();
            
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
        for (int i = 0; i < bestLenth; i++)
        {
            Console.Write("{0}, ", bestSeq);
        }
        Console.WriteLine();
    }
}
