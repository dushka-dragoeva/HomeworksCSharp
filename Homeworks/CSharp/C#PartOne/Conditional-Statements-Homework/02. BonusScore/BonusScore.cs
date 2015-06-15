using System;

class BonusScore
{
    static void Main(string[] args)
    {   
        //02.Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        //If the score is between 1 and 3, the program multiplies it by 10.
        //If the score is between 4 and 6, the program multiplies it by 100.
        //If the score is between 7 and 9, the program multiplies it by 1000.
        //If the score is 0 or more than 9, the program prints “invalid score”.

        Console.Write("Please enter the score ");
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 3)
        {
            int result = score * 10;
            Console.WriteLine("The result is{0} ", result);
        }
        else if (score >= 4 && score <= 6)
        {
            int result = score * 100;
            Console.WriteLine("The result is{0} ", result);
        }
        else if (score >= 7 && score <= 9)
        {
            int result = score * 1000;
            Console.WriteLine("The result is{0} ", result);
        }
        else 
        {
            string text = "Invalid score";
            Console.WriteLine(text);
        }
    }
}

