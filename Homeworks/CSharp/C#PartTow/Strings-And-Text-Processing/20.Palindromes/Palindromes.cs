using System;
using System.Collections.Generic;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter a text, containig palindromes:");
        
        string []inputText =Console.ReadLine().Split(new char [] {' ',',','.', '!','?'},StringSplitOptions.RemoveEmptyEntries);
         List<string> palindromes = new List<string>();

       for (int i = 0; i < inputText.Length; i++)
       {
           if ( IsPalindromes(inputText[i]))
           {
               palindromes.Add(inputText[i]);
           }
       }
       for (int i = 0; i < palindromes.Count; i++)
       {
           Console.WriteLine(palindromes[i]);
       }
    }
    static bool IsPalindromes(string word)
    {
        bool isPalindromes = true;
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                isPalindromes = false;
                break;
            }
        }
        return isPalindromes;
    }
}