using System;
using System.Linq;

    class MaximalSum
    {
        static void Main()
        {
        //Write a program that finds the sequence of maximal sum in given array.
        //Example:

        //input	                                      result
        //2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2,       -1, 6, 4
        
        //Console.Write("Enter integers seperated with comma:  ");
        //string input = Console.ReadLine();
        string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8	 2";
        int[] newArr = input
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int bestSum = 0;
        int currentSum = newArr[0];
        string sum = "";
        string tempSum = newArr[0] + "";


        for (int i = 1; i < newArr.Length-1; i++)
           {
               if(newArr[i]+newArr[i+1] >currentSum)
               {
                   currentSum += newArr[i + 1];
                   tempSum += "," + newArr[i + 1]  ;
               }
                else
               {
                   currentSum = newArr[i+1];
                   tempSum = newArr[i+1] + "";
               }
               if (currentSum > bestSum)
               {
                   bestSum = currentSum;
                   sum = tempSum + "";
               }
        }
        Console.WriteLine(sum);
        }
    }

