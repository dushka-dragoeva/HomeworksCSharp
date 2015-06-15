using System;

class AllocateArray
{
    static void Main()
    {
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        //Print the obtained array on the console.

        int[] firstArray = new int [20];
        for (int i=0;i<firstArray.Length;i++)
        {
            Console.Write("{0} ", i * 5);
        }
    }
}
