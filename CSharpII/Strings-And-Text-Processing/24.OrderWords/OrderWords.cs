using System;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
class OrderWords
{
    static void Main()
    {
        //Console.WriteLine("Enter words, separated by spaces: ");
        //string input = Console.ReadLine();
        string input = "This question is unlikely to help any future ";
        string[] words = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}