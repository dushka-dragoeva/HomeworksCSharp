using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static void Main()
    {
        //Write a program that finds the index of given element in a sorted array of integers 
        //by using the Binary search algorithm.

        //Console.Write("Enter sorted array of integers :  ");
        string input = "12, 17, 18, 19, 20, 22, 33, 44, 55, 77, ";//Console.ReadLine()
        int[] newArr = input
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .ToArray();
        //Console.Write(" Enter key  ");
        int key = 18; //int.Parse(Console.ReadLine());

        Array.Sort(newArr);
        int mid = 0;
        int minIndex = 0;
        int maxIndex = newArr.Length;
        bool findKey = false;
        
        while(minIndex<=maxIndex)
        {
            mid = minIndex+(maxIndex + minIndex) / 2;
            if (newArr[mid] < key)
            {
                minIndex = mid+1;
                continue;
            }
            else if (newArr[mid] > key)
            {
                maxIndex = mid-1;
                continue;
            }
            else if (newArr[mid] == key)
            {
                findKey = true;
                break;
            }
        }
        if (findKey == true)
        {
            Console.WriteLine("Key {0} has index {1}.", key, mid);
        }
        else
        {
            Console.WriteLine("Key is not found.");
        }
    }
}