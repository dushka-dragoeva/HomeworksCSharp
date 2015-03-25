/*Emplement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
 and has the same functionality as Substring in the class String.*/
namespace _01.StringBuilder
{
    using System;
    using System.Text;
    using _01.StringBuilder.Extentions;

    class StringbulderExtentions
    {
        static void Main()
        {
            var text = new StringBuilder();
            text.Append("Cats and Dogs are very nice pets.");
            var result = text.Substring(5, 8);
            result.Append(" are so cute!");
         
            Console.WriteLine(result);
        }
    }
}
