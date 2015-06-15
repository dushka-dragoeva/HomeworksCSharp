using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

class IndexOfLetters
{
    static void Main()
    {
        int[] alphabet = new int[26];
        for (char i = 'A'; i <= 'Z'; i++)
        {
            alphabet[i - 65] = i;
        }
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < alphabet.Length; i++)
        {
            foreach (char let in word)
            {
                if (let == alphabet[i])
                {
                    Console.WriteLine("Letter '{0}' - index: {1} ", let, i);
                }
            }
        }
    }
}

