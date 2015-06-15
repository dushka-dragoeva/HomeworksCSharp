using System;

class LargerThanNeighbours
//05.	Write a method that checks if the element at given position in given array of integers is larger than 
//  its two neighbours (when such exist).
{
    static bool CheckNeighbours(int[]arr, int position)
    {
 
    bool isLarger=false;
            if(position>0 && position<arr.Length-1)
            {
                if( arr[position ]>arr[position-1]&& arr[position]>arr[position+1])
                {
                    isLarger = true;
                }
                else
                {
                    Console.WriteLine("There are no neighbours to compare ");
                }
            }
        
        return isLarger;
    }    

    static void Main()
    {
        int[] myArr = { 45, 2, 33, -7, 2, 23, 2, -7, 43, -76, 8, -663, 2, -7 };
        int myPosition = 2;

        if(CheckNeighbours(myArr, myPosition))
        {
            Console.WriteLine("{0} is greater than {1} and {2} ", myArr[myPosition], myArr[myPosition - 1], myArr[myPosition + 1]);
        }
        else
        {
            Console.WriteLine("{0} is not greater than {1} and {2} ", myArr[myPosition], myArr[myPosition - 1], myArr[myPosition + 1]);
        }
    }
}

