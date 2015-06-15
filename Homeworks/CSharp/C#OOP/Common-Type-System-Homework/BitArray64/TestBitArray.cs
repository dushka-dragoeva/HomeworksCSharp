//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray64
{
    using System;

    class TestBitArray
    {
        static void Main(string[] args)
        {

            BitArray64 number1 = new BitArray64(5);
            BitArray64 number2 = new BitArray64(5);
            Console.WriteLine(String.Join("", number1.BitArray));

            //Test indexer
            Console.WriteLine(number1[0]);
            number1[3] = 1;

            //Test Equals
            Console.WriteLine(number1 == number2);

            //Test "=="
            Console.WriteLine(number1.Equals(number2));

            //Test enumerator
            foreach (var item in number1)
            {
                Console.Write(item);
            }

            //Test GetHashCode
            Console.WriteLine(number1.GetHashCode());
            Console.WriteLine(number2.GetHashCode());
        }
    }
}