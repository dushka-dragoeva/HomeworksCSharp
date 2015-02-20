using System;

class BinarySearch
{
    static void Main()
    {
        /*•	Write a program, that reads from the console an array of N integers and an integer K, 
         * sorts the array and using the method Array.BinSearch() finds the largest number in the 
         * array which is ≤ K.*/

        // int k = 15;
        //int[] arr = { 11, 12, 13, 5, 16, 7, 8, };

        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter max value: ");
        int k = int.Parse(Console.ReadLine());

        string text = "The largest number in array <= {0} is {1}";
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}]= ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        if (arr[0] > k)
        {
            Console.WriteLine("All numbers are bigger.");
        }

        int binaryIndex = Array.BinarySearch(arr, 0, arr.Length, k);
        
        
        if (binaryIndex >= 0)
        {
            Console.WriteLine(text, k, arr[binaryIndex]);
        }
        else
            Console.WriteLine(text, k, arr[(-binaryIndex) - 2]);
    }
}

