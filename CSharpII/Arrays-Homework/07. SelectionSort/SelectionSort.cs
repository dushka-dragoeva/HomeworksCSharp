using System;
using System.Linq;

class SelectionSort
{
    static void Main(string[] args)
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        //Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
        //find the smallest from the rest, move it at the second position, etc.

        //Console.Write("Enter lenth N for the array  ");
        //int n = int.Parse(Console.ReadLine());
        //int[] newArr = new int[n];
        //for (int i = 0; i < newArr.Length; i++)
        //{
        //    Console.Write("Enter element with index {0}  ", i);
        //    newArr[i] = int.Parse(Console.ReadLine());
        //}

        int[] newArr = { 12, 56, -7, 96, 33, 4, 6, 98, -4, 10, 99, 139, -95};
        int minIndex;
        int minElement;

        for (int i = 0; i < newArr.Length - 1;i++ )
        {
            minIndex = i;
            for (int j = i+1; j < newArr.Length; j++)
            {
               
                if (newArr[minIndex] > newArr[j])
                {
                    minIndex = j;
                }
                
            }
            minElement = newArr[i];
            newArr[i] = newArr[minIndex];
            newArr[minIndex] = minElement;
        }

        foreach (var num in newArr)
        {
            Console.Write(num + ", ");
        }
        Console.WriteLine();
    }

}