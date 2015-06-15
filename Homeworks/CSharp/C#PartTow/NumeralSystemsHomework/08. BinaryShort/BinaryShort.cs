using System;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BinaryShort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter short number (16 bit):  ");
        short number = short.Parse(Console.ReadLine());
        shortBimnary(number);
    }
    static void shortBimnary(short shortToBinary)
    {
        byte[] BinaryNumber = new byte[16];
        if (shortToBinary < 0)
        {
            BinaryNumber[0] = 1;
            shortToBinary = Math.Abs(shortToBinary);
        }
        for (int i = BinaryNumber.Length - 1; i > 0; i--)
        {
            if (shortToBinary == 0)
            {
                break;
            }
            else
            {
                BinaryNumber[i] = Convert.ToByte(shortToBinary % 2);
                shortToBinary = Convert.ToInt16( shortToBinary / 2);
            }
        }
        Console.WriteLine(string.Join("", BinaryNumber));
    }
}

