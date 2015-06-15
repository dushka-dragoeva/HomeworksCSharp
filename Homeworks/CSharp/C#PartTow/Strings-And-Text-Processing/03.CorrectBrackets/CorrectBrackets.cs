using System;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

class CorrectBrackets
{
    static void Main()
    {
        //  Console.Write("Enter string: ");
        // string input = Console.ReadLine();
        string input = " ((a+b)/5-d)";
        // string input = ")(a+b))";
        bool correct = CheckBrackets(input);
        if (correct)
        {
            Console.WriteLine("Brackets are correct");
        }
        else
        {
            Console.WriteLine("Incorrect brackets");
        }
    }
    static bool CheckBrackets(string expression)
    {
        int counter = 0;
        if (expression[0] == ')')
        {
            return false;
        }
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[0] == '(')
            {
                counter++;
            }

            else if (expression[0] == ')')
                counter--;
        }
        if (counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
