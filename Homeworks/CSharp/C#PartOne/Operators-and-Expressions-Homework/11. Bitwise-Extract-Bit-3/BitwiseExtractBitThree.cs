using System;

    class BitwiseExtractBitThree
    {
        static void Main(string[] args)
        {
            // 11. Bitwise: Extract Bit #3
            //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.         
            
            Console.Write("Please Enter Positive Integer:  ");
            int position = 3;
            int number = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << position;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;
            Console.WriteLine("The binari  number   is "  + Convert.ToString(number,2).PadLeft(32,'0'));
            Console.WriteLine("The value of the bit # "+position + " is:  " + bit);
           }
    }