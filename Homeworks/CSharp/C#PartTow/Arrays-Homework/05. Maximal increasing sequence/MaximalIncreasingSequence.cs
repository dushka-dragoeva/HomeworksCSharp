using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array.
        //Example:
        //input	                    result
        //3, 2, 3, 4, 2, 2, 4	    2, 3, 4

        //Console.Write("Enter integers seperated with comma:  ");
        //string input = Console.ReadLine();
        string input = "3, 2, 3, 4, 2, 2, 4";
        int[] newArr = input
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int lenth = 1;
        int bestLenth = 1;
        string sequence = "";
        string currentSec = newArr[0]+ ", ";

        for (int i = 1; i < newArr.Length; i++)
        {
            if (newArr[i - 1] < newArr[i])
            {
                lenth++;
                currentSec += newArr[i] +", " ;

                if (lenth > bestLenth)
                {
                    bestLenth = lenth;
                    sequence = currentSec;
                }
            }
            else
            {
                lenth = 1;
                currentSec = newArr[i]+ ", ";
            }
        }    
        Console.WriteLine(sequence);
    }
}

