using System;
using System.Linq;
using System.Collections.Generic;

public class SubtractingPolynomials
{
    static void Main()
    {
        /*•	Extend the previous program to support also subtraction and multiplication of polynomials.*/

        decimal[] firstPol = EnterPolynomial(out firstPol);
        decimal[] secondPol = EnterPolynomial(out secondPol);

        //decimal[] firstPol = { -1, -1, -1, -1, -7, -7 };
        //decimal[] secondPol = { 3.5m, 3, 3, 4.5m, -2 };
        
        Console.WriteLine("First polynomial \n");
        PrintingPolinomus(firstPol);
        Console.WriteLine("Second polynomial \n");
        PrintingPolinomus(secondPol);
        Console.WriteLine("Subtraction polynomial subtraction ( first-second) \n");
        PrintingPolinomus(SubtractingPolynomias(firstPol, secondPol));
        Console.WriteLine("Multiplication of polynomials\n");
        PrintingPolinomus(MultiplicationPolynomias(firstPol, secondPol));
    }

    //reading coeficients from the console
    static decimal[] EnterPolynomial(out decimal[] polynomial)
    {
        Console.Write("Enter your polynomial degree: ");
        byte degree = byte.Parse(Console.ReadLine());

        polynomial = new decimal[degree + 1];

        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + ": ");
            polynomial[i] = decimal.Parse(Console.ReadLine());
        }
        return polynomial;
    }
    // Substracting arrays
    static decimal[] SubtractingPolynomias(decimal[] a, decimal[] b)
    {
        decimal[] c = new decimal[Math.Max(a.Length, b.Length)];

        if (a.Length > b.Length)
        {
            decimal[] copyB = b;
            b = new decimal[a.Length];
            for (int i = 0; i < copyB.Length; i++)
            {
                b[i] = copyB[i];
            }
        }
        if (a.Length < b.Length)
        {
            decimal[] copyA = a;
            a = new decimal[b.Length];
            for (int i = 0; i < copyA.Length; i++)
            {
                b[i] = copyA[i];
            }
        }
        for (int i = 0; i < c.Length; i++)
        {
            c[i] = a[i] - b[i];
        }
        return c;
    }

    // Substracting arrays
    static decimal[] MultiplicationPolynomias(decimal[] a, decimal[] b)
    {
        decimal[] c = new decimal[a.Length+ b.Length-1];
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j <b.Length; j++)
            {
                c[i+j] += a[i]* b[j]  ;
            }
        }
            return c;
    }
    //printing
    static void PrintingPolinomus(decimal[] a)
    {
        string polinomus = string.Empty;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            //addPol[i]= a[i] + b[i];
            if (a[i] != 1 && a[i] > 0 && i == (a.Length - 1))
            {
                polinomus += a[i] + "x^" + i;
            }
            else if (a[i] != 1 && a[i] > 0 && i > 1 && i != (a.Length - 1))
            {
                polinomus += " + " + a[i] + "x^" + i;
            }
            else if (a[i] != 1 && a[i] > 0 && i == 1)
            {
                polinomus += " + " + a[i] + "x";
            }
            else if (a[i] > 0 && i == 0)
            {
                polinomus += " + " + a[i];
            }
            else if (a[i] != -1 && a[i] < 0 && i > 1)
            {
                polinomus += " " + a[i] + "x^" + i;
            }
            else if (a[i] != -1 && a[i] < 0 && i == 1)
            {
                polinomus += " " + a[i] + "x";
            }
            else if (a[i] < 0 && i == 0)
            {
                polinomus += " " + a[i];
            }
            else if (a[i] == 1 && i == (a.Length - 1))
            {
                polinomus += "x^" + i;
            }
            else if (a[i] == 1 && i > 1 && i != (a.Length - 1))
            {
                polinomus += " + x^" + i;
            }
            else if (a[i] == 1 && i == 1)
            {
                polinomus += " + x";
            }
            else if (a[i] == -1 && i > 1)
            {
                polinomus += " - x^" + i;
            }
            else if (a[i] == -1 && i == 1)
            {
                polinomus += " - x";
            }
        }
        Console.WriteLine(polinomus + "\n");
    }
}