using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        //13.Check a Bit at Given Position
        //Write a Boolean expression that returns if the bit at position p 
        //(counting from 0, starting from the right) in given integer number n, has value of 1

        Console.Write("Please Enter Positive Integer:  ");
        int number = Int32.Parse(Console.ReadLine());
        Console.Write("Please Enter position from 0 to 31: ");
        int position = Int32.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        bool check = (bit == 1);
        Console.WriteLine("The binari for number  " + number + "  is  " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The value of the bit # " + position + " is = 1 -  "  + check);



    }
}

