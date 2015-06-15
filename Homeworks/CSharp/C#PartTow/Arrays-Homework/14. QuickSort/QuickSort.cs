using System;
using System.Linq;

//Write a program that sorts an array of integers using the Quick sort algorithm.
class QuickSort
{
    
    static void Main(string[] args)
    {
        //Console.Write("Enter array of integers :  ");
        string input = "52, 37, -18, 19, 20, 22, 33, 44, -55, 77, ";//Console.ReadLine()
        int[] newArr = input
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();

        QuickSortAlgorithm(newArr, 0, newArr.Length - 1);
        for (int i=0; i<newArr.Length;i++)
        {
            Console.Write(newArr[i] + " ");
        }
        Console.WriteLine();
    }
    static void QuickSortAlgorithm ( int[] sortArr, int left, int right)
    {
        if (left >= right)
        {
            return;
        }
        int pivotIndex = (left + right) / 2;
        int leftIndex = left;
        int rightIndex = right;
        int pivotInt = sortArr[pivotIndex];
        while (leftIndex <= rightIndex)
        {
            while (sortArr[leftIndex].CompareTo(pivotInt) < 0)
            {
                leftIndex++;
            }

            while (sortArr[rightIndex].CompareTo(pivotInt) > 0)
            {
                rightIndex--;
            }
            if (leftIndex <= rightIndex)
            {
                int tempElement = sortArr[leftIndex];
                sortArr[leftIndex] = sortArr[rightIndex];
                sortArr[rightIndex] = tempElement;
                leftIndex++;
                rightIndex--;
            }
            if (left < rightIndex)
            {
                QuickSortAlgorithm(sortArr, left, rightIndex);
            }
            if (right > leftIndex)
            {
                QuickSortAlgorithm(sortArr, leftIndex, right);
            }
        }
    }
}
