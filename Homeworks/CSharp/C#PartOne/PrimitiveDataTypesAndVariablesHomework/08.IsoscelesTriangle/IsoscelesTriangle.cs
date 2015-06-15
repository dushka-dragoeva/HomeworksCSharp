using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        //8. Isosceles Triangle
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:   
        //The © symbol may be displayed incorrectly at the console so you may need to change the console 
        //character encoding to UTF-8 and assign a Unicode-friendly font in the console
        Console.OutputEncoding = Encoding.UTF8;
        char Copyright = '\u00A9';
        Console.WriteLine ("\t   {0}\n\n\n\t  {0} {0}\n\n\n\t {0}   {0}\n\n\n\t{0} {0} {0} {0}", Copyright);
    }
}