﻿using System;
using System.Collections.Generic;
using System.IO;

/*  Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
    Example:
    input.txt 	output.txt
    Ivan        George
    Peter       Ivan
    Maria       Maria
    George 	    Peter
*/

class SaveSortedNames
{
    static void Main()
    {
        //file is in 'bin/Debug' directory of the project
        using (StreamReader unsorted = new StreamReader(@"..\..\input.txt"))
        {
            List<string> names = new List<string>();
            for (string currName = unsorted.ReadLine(); currName != null; currName = unsorted.ReadLine())
            {
                names.Add(currName);
            }
            names.Sort();
            using (StreamWriter sorted = new StreamWriter(@"..\..\output.txt"))
            {
                foreach (string name in names)
                {
                    sorted.WriteLine(name);
                }
            }
            using (StreamReader sorted =new StreamReader (@"..\..\output.txt"))
            {
                var line = sorted.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("Names are sorted!");
    }
}
