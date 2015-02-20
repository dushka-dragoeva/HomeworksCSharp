using System;
using System.Linq;
using System.Collections.Generic;

class SortingArray
{
    static void Main()
    {
        /*•	Write a method that return the maximal element in a portion of array of integers starting 
         *  at given index.
          •	Using it write another method that sorts an array in ascending / descending order.*/

        int[] myArr = { 45, -33, -7, 2, 23, 43, -76, 8, -663 };

        SortArrAscendingDescending(myArr);

        // Printing Ascending
        for (int i = myArr.Length - 1; i >= 0; i--)
        {
            Console.Write(myArr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        //Printing Descending
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write(myArr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    static int MaxElement(int[] arr, int index)
    {
        int maxValue = int.MinValue;
        int maxIndex = 0;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    static void SortArrAscendingDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Swap(arr, i, MaxElement(arr, i));
        }
    }
    static void Swap(int[] array, int j, int i)
    {
        int t = array[j];
        array[j] = array[i];
        array[i] = t;
    }
}
