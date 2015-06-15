using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        //14. Modify a Bit at Given Position
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p.
        //write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
        //from the binary representation of n while preserving all other bits in n.
            
        Console.Write("Please Enter Positive Integer:  ");
        int number = Int32.Parse(Console.ReadLine());
        Console.Write("Please Enter position from 0 to 31: ");
        int position = Int32.Parse(Console.ReadLine());
        Console.Write("Please Enter Bit value 0 or 1:  ");
        int bitValue = Int32.Parse(Console.ReadLine());
        int mask=0;
        if (bitValue == 0)
        {
            mask = ~(1 << position);
            int numberAndMask = number & mask;
            int bit = numberAndMask >> position;
            Console.WriteLine("The binari is  " + Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Binary Rezult  \t{0}, \t \nNew number \t {1} ", 
                                Convert.ToString(numberAndMask, 2).PadLeft(32, '0'), numberAndMask);
        }
        else
        {
            mask = 1 << position;
            int numberAndMask = number | mask;
            int bit = numberAndMask >> position;
            Console.WriteLine("The binari is  " + Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("Binary Rezult \t{0}, \t \nNew number \t {1} ", 
                                Convert.ToString(numberAndMask, 2).PadLeft(32, '0'), numberAndMask);
        }               
    }
}