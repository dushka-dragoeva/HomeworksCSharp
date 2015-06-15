﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintDeck52Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Write a program that generates and prints all possible cards from a standard deck of 52 cards 
            //(without the jokers). The cards should be printed using the classical notation 
            //(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            //The card faces should start from 2 to A.
            //Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

            string str = " ";
                for (int i = 0; i < 13; i++)
                {
                    switch(i)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            str = (i + 2).ToString();
                            break;
                        case 9: str = "J"; break;
                        case 10:str = "D"; break;
                        case 11:str = "K";break;
                        case 12:str = "A";break;
                    default:
                        break;
                    }

                    for (int j=0;j<4;j++)
                    {
                        switch (j)
                        {
                            case 0:
                                Console.Write((char)6+"{0,2} of spades ,  ", str);
                                break;
                            case 1:
                                Console.Write((char)5+"{0,2} of clubs,  ", str);
                                break;
                            case 2:
                                Console.Write((char)3+"{0,2} of hearts,  ", str);
                                break;
                            case 3:
                                Console.Write((char)4+"{0,2} of diamonds,  ", str);
                                break;
                            default:
                                break;
                    }

                    }

                    Console.WriteLine();


           }


        }
    }
}

