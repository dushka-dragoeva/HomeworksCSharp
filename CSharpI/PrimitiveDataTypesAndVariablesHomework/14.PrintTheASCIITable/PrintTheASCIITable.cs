using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        // 14.* Print the ASCII Table
        //Find online more information about ASCII (American Standard Code for Information Interchange) and write a program 
        //that prints the entire ASCII table of characters on the console (characters from 0 to 255).
        short number = 0;
        for (number = 0; number <= 255; number++)
        Console.WriteLine("The code for " + (char)number + "   is   " + number);
    }
}