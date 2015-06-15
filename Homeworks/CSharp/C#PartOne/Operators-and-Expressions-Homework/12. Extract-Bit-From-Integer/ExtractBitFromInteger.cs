using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        //12. Extract Bit from Integer
        //Write an expression that extracts from given integer n the value of given bit at index p.

        Console.Write("Please Enter Positive Integer:  ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please Enter position from 0 to 31:  ");
        int position = Convert.ToInt32(Console.ReadLine());        
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("The binari for number  " + number + "  is  " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The value of the bit #" + position + " is:  " + bit);
    }
}