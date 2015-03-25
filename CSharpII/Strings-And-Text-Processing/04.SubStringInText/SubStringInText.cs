using System;

/*Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:
The target sub-string is in
The text is as follows: We are living in an yellow submarine. 
 * We don't have anything else. inside the submarine is very tight. 
 * So we are drinking all the day. We will move out of it in 5 days.
    The result is: 9*/

class SubStringInText
{
    static void Main()
    {
        string text = @" We are living in  an yellow submarine. We don't have anything else. inside 
            the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string subText = "in";
        int index = 0;
        int counter = 0;
        while (true)
        {
            int found = text.ToLower().IndexOf(subText, index);
            if (found < 0)
            {
                break;
            }
            else
            {
                index = found + 1;
            }
            counter++;
        }
        Console.WriteLine("The result is: " + counter);
    }
}