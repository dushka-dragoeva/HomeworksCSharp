using System;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.

class ReverseString
{
    static void Main()
    {
        // Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        string input = "sample";
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        Console.WriteLine(reversed);
    }
}