using System;
using System.Text;

/* Write a program that reverses the words in given sentence.
Example:
input	                                    output
C# is not C++, not PHP and not Delphi!	    Delphi not and PHP, not C++ not is C#!
Problem 14. Word dictionary*/

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] splitted = sentence.Split(new char[] { ' ', ',', '.', '!' },
        StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(splitted);
        int countCommas = 0;
        int countSpaces = 0;
        char lastSign = sentence[sentence.Length - 1];
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ',')
            {
                countCommas++;
            }
        }
        int[] comaAtPosition = new int[countCommas];
        int currentComa = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                countSpaces++;
            }
            if (sentence[i] == ',')
            {
                comaAtPosition[currentComa] = countSpaces;
                currentComa++;
            }
        }
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < splitted.Length; i++)
        {
            for (int j = 0; j < comaAtPosition.Length; j++)
            {
                result.Append(splitted[i]);
                if (comaAtPosition[j] == i)
                {
                    result.Append(", ");
                }
                else if (i != splitted.Length - 1)
                {
                    result.Append(' ');
                }
            }
        }
        result.Append(lastSign);
        Console.WriteLine(result);
    }
}