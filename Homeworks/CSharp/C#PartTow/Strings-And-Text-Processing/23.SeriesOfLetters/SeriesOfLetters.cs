using System;
using System.Collections.Generic;

/*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:
input	                        output
aaaaabbbbbcdddeeeedssaa	     abcdedsa*/

class SeriesOfLetters
{
    static void Main()
    {
        //Console.WriteLine("Enter text:");
        //string input = Console.ReadLine();
        string input = "aaaaabbbbbcdddeeeedssaa";
        List<char> singleLetters = new List<char>();
        singleLetters.Add(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if(input[i-1]==input[i])
            {
                continue;
            }
            else
            {
                singleLetters.Add(input[i]);
            }
        }
        Console.WriteLine(string.Join("",singleLetters));
    }
}