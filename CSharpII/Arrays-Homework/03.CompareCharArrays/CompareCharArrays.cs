using System;

class CompareCharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter)

        Console.Write("Enter lenth N for first array  ");
        int n = int.Parse(Console.ReadLine());
        char[] firstArr = new char[n];
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Enter element with index {0}  ", i);
            firstArr[i] = char.Parse(Console.ReadLine());
        }
        Console.Write("Enter lenth M for second array  ");
        int m = int.Parse(Console.ReadLine());
        char[] secondArr = new char[m];
        for (int j = 0; j < secondArr.Length; j++)
        {
            Console.Write("Enter element with index {0}  ", j);
            secondArr[j] = char.Parse(Console.ReadLine());
        }

        if (firstArr.Length != secondArr.Length)
        {
            Console.WriteLine("Two arrays have different lenght.");
        }
        else
        {
            Console.Write("Two arrays have equal lenght ");
        }
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                Console.WriteLine("but different elements.");
                break;
            }
        }
        Console.WriteLine("and equal elements.");
    }
}





