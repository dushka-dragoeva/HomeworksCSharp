﻿using System;

class DeclareVariables
{
    static void Main()
    {
        //1. Declare Variables
        //Declare five variables choosing for each of them the most appropriate of the types byte, 
        //sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
        
        ushort a = 52130;
        sbyte b = -115;
        uint c = 4825932;
        byte d = 97;
        short e = -10000;
        Console.WriteLine("The most appropriate of the types for \t {0} is \t ushort", a);
        Console.WriteLine("The most appropriate of the types for  \t {0} is \t sbyte", b);
        Console.WriteLine("The most appropriate of the types for \t {0} is \t uint", c);
        Console.WriteLine("The most appropriate of the types for  \t   {0} is \t byte", d);
        Console.WriteLine("The most appropriate of the types for \t {0} is \t short", e);
    }
}