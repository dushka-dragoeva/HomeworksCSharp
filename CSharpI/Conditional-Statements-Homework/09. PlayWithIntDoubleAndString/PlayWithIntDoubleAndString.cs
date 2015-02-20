using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        //09ite a program that, depending on the user’s choice, inputs an int, double or string variable.
        //If the variable is int or double, the program increases it by one.
        //If the variable is a string, the program appends * at the end.
        //Print the result at the console. Use switch statement.
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please choose a Type: \n1-->int\n2-->double\n3-->string   ");
        int choice = int.Parse(Console.ReadLine());
        string text = "Please enter a";
        switch (choice)
        {
            case 1: Console.WriteLine(text + "n integer: ");
                int firstChoice = int.Parse(Console.ReadLine());
                Console.Write(firstChoice + 1);
                break;
            case 2: Console.WriteLine(text + " double: ");
                double secondChoice = double.Parse(Console.ReadLine());
                Console.Write(secondChoice + 1);
                break;
            case 3: Console.WriteLine(text + " string:  ");
                string thirdChoice = Console.ReadLine();
                Console.WriteLine(thirdChoice);
                break;
            default: Console.WriteLine("Wrong Choice");
                break;
        }
    }
}