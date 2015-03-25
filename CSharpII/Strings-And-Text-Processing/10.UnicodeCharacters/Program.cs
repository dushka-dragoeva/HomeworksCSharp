using System;
using System.Text;
/* Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:
input	           output
Hi!	              \u0048\u0069\u0021   */
namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main()
        {  
            //string input = Console.ReadLine();
            string input = "Hi!";
            StringBuilder convertUnicode = new StringBuilder();
            foreach (var symbol in input)
            {
                convertUnicode.AppendFormat ("\\u{0:x4}", (int)symbol);
            }
            Console.WriteLine(convertUnicode);
        }
    }
}