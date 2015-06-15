using System;
using System.Linq;

//Write a program that sorts an array of integers using the Merge sort algorithm.
class MergeSort
{
    static void Main(string[] args)
    {
        //Console.Write("Enter array of integers :  ");
        string input = "52, 37, -18, 19, 20, 22, 33, 44, -55, 77, ";//Console.ReadLine()
        int[] newArr = input
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();

        SortMerge(newArr, 0, newArr.Length - 1);

        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write(newArr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Merge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, eol, num, pos;

        eol = (mid - 1);
        pos = left;
        num = (right - left + 1);

        while ((left <= eol) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[pos++] = numbers[left++];
            else
                temp[pos++] = numbers[mid++];
        }

        while (left <= eol)
            temp[pos++] = numbers[left++];

        while (mid <= right)
            temp[pos++] = numbers[mid++];

        for (i = 0; i < num; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static void SortMerge(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, (mid + 1), right);
            Merge(numbers, left, (mid + 1), right);
        }
    }
}