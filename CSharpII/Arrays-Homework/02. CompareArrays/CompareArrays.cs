using System;

class CompareArrays
{
    static void Main()
    {
        //Write a program that reads two integer arrays from the console and compares them element by element.

        Console.Write("Enter lenth N for first array  ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.Write("Enter element with index {0}  ", i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter lenth M for second array  ");
        int m = int.Parse(Console.ReadLine());
        int[] secondArr = new int[m];
        for (int j = 0; j < secondArr.Length; j++)
        {
            Console.Write("Enter element with index {0}  ", j);
            secondArr[j] = int.Parse(Console.ReadLine());
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

