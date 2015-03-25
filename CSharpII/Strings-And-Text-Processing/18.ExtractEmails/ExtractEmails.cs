using System;
using System.Collections.Generic;

/*Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Enter a text, containig e-mails(<identifier>@<host>…<domain>) :");
        
        string []inputText =Console.ReadLine().Split(new char [] {' ',',', '!','?'},StringSplitOptions.RemoveEmptyEntries);
         List<string> eMails = new List<string>();

       for (int i = 0; i < inputText.Length; i++)
       {
           if ( inputText[i].IndexOf('@')>0&& inputText[i].IndexOf('.',inputText[i].IndexOf('@'))>0)
           {
               eMails.Add(inputText[i]);
           }
       }
       for (int i = 0; i < eMails.Count; i++)
       {
           Console.WriteLine(eMails[i]);
       }
    }
}

