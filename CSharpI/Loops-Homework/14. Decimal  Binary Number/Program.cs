using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Decimal__Binary_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Decimal: ");
            long decimalNumber = long.Parse(Console.ReadLine());

            long remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}", result);

        }
    }
}
