using System;

class FirstLargerThanNeighbours
{   /*•	Write a method that returns the index of the first element in array that is larger than
    *  its neighbours, or -1, if there’s no such element.
    •	Use the method from the previous exercise.*/

    static bool CheckNeighbours(int[] arr, int position)
    {
        bool isLarger = false;
        if (position > 0 && position < arr.Length - 1)
        {
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                isLarger = true;
            }
        }

        return isLarger;
    }
    
    static void Main()
    {
        int[] myArr = { 45, 2, -33, -7, 2, 23, 2, -7, 43, -76, 8, -663, 2, -7 };
        int index = -1;
        for (int i = 1; i < myArr.Length - 1; i++)
        {
            if (CheckNeighbours(myArr, i))
            {
                index = i;
                break;
            }
        }
        Console.WriteLine("The index of the first element is  " + index);
    }
}
