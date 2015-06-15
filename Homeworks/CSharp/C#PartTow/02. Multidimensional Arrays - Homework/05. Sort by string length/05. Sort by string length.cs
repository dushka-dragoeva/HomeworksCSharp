using System;

class SortByStringLengh
{
    static void Main()
    {
        //•	You are given an array of strings. Write a method that sorts the array by the length of its 
        //  elements (the number of characters composing them).

        string[] words = { "red", "black", "yellow", "n","blue", "hi" };
        int[] index =new int[words.Length];

        string tempMin = string.Empty;

        for (int j = 0; j < words.Length; j++)
        {
            for (int i = 0; i < words.Length-1 ; i++)
            {
                if (words[j].Length < words[i].Length)
                {
                    tempMin = words[i];
                    words[i] = words[j];
                    words[j] = tempMin;
                }
            }
        }
          for (int i=0;i<words.Length;i++)
          {
              Console.Write(words[i]);
              if(i!=words.Length-1)
              {
                  Console.Write(", ");
              }
          }
          Console.WriteLine();
    } 
}
