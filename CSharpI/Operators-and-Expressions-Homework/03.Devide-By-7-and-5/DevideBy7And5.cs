using System;

class DevideBy7And5
{
    static void Main()
    {
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
        //by 7 and 5 at the same time
        
        Console.Write("Please enter an integer  ");
        int number = int.Parse(Console.ReadLine());
        
        //проверявяме дали числото се дели на 35 (7*5), 
        //защото 7 и 5 нямат общ делител
                
        bool check = (number % 35== 0);
        Console.WriteLine("The number {0} can be devidid by 7 and 5 -  {1}", number, check);
    }
}

