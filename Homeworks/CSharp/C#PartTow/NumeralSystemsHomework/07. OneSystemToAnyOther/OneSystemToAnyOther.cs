using System;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter base S >=2:  ");
        byte baseS = byte.Parse(Console.ReadLine());
        Console.Write("Enter base D <=16:  ");
        byte baseD = byte.Parse(Console.ReadLine());
        Console.Write("Enter a number in {0} system:  ", baseS);
        string number = (Console.ReadLine());
        number = number.ToUpper();
        string newNum = string.Empty;
        if (baseS == 10)
        {
           long decNum= Convert.ToInt64(number);
           newNum = DecimalToBaseB(baseD, decNum);
        }
        else if (baseD==10)
        {
            newNum =  Convert.ToString (NumberToDecimal(baseS, number));
        }
        else
        {
            newNum = ConvertOneSystemToAnother(baseS, baseD, number);
        }
        Console.WriteLine(" Tne number in {0} is: {1}", baseD, newNum);
    }
    static string ConvertOneSystemToAnother(byte baseA, byte baseB, string numToConvert)
    {
        long convertToDec = NumberToDecimal(baseA, numToConvert);
        string convertedNum = DecimalToBaseB(baseB, convertToDec);
        return convertedNum;
    }
    static long NumberToDecimal(byte baseA, string num)
    {
        long decimalNumber = 0;
        for (int i = 0; i < num.Length; i++)
        {
            int digit = 0;
            int position = num.Length - i - 1;
            if (num[i] >= '0' && num[i] <= '9')
            {
                digit = num[i] - '0';
            }
            else if (num[i] >= 'A' && num[i] <= 'F')
            {
                digit = num[i] - 'A' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(baseA, position);
        }
        return decimalNumber;
    }
    static string DecimalToBaseB(byte baseB, long decimalToBaseB)
    {
        string baseBStr = string.Empty;

        while (decimalToBaseB > 0)
        {
            var digit = (decimalToBaseB % baseB);
            if (digit >= 0 && digit < 10)
            {
                baseBStr = (char)(digit + '0') +baseBStr;
            }
            else
            {
                baseBStr = (char)(digit - 10 + 'A') + baseBStr;
            }
            decimalToBaseB = decimalToBaseB / baseB;
        }
        return baseBStr;
    }

}