namespace Printer
{
    using System;

    internal class BooleanPrinter
    {
        internal void PrintBooleanAsString(bool value)
        {
            string boolAsString = value.ToString();
            Console.WriteLine(boolAsString);
        }
    }
}
