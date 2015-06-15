using System;

class PrintLongSequence
{
    static void Main(string[] args)
    {
         for (short number = 2; number <= 1000; number++)
        {
            if (number % 2 == 0)
            {             
                Console.Write(number);
            }   
            else
            {
                 Console.Write(-number);
            }

            if (number < 1000)                     
            {
                    Console.Write(", ");
            }
        }
    }
}
