using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

public class AddingPolynomials
{
    static void Main()
    {
        /*•	Write a method that adds two polynomials.
          •	Represent them as arrays of their coefficients.
         Example:
        x^2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1}*/
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal[] firstPol = EnterPolynomial(out firstPol);
        decimal[] secondPol = EnterPolynomial(out secondPol);

        // decimal[] firstPol = { -1, -1, -1, -1, -7, -7 };
        //decimal[] secondPol = { 3.5m, 3, 3, 4.5m, -2 };
        Console.WriteLine("First polynomial");
        PrintingPolinomus(firstPol);
        Console.WriteLine("Second polynomial");
        PrintingPolinomus(secondPol);
        Console.WriteLine("Added Polynomials");
        PrintingPolinomus(AddingPolynomias(firstPol, secondPol));
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
    // Adding arrays
    static decimal[] AddingPolynomias(decimal[] a, decimal[] b)
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
            c[i] = a[i] + b[i];
        }
        return c;
    }
    //printing
    public static void PrintingPolinomus(decimal[] a)
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
        Console.WriteLine("\n"+polinomus+"\n");
    }
}