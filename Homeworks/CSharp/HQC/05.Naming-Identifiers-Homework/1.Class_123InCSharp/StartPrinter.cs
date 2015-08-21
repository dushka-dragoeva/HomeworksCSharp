// task 1
namespace Printer
{
    using System;

    internal class StartPrinter
    {
        private const int MaxConst = 6;

        public static void Main()
        {
            var printer = new BooleanPrinter();
            printer.PrintBooleanAsString(true);
        }
    }
}