using System;
using System.Globalization;

/*
 Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
 and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/
class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine ("Enter date in format (dd.MM.yyyy HH:mm:ss) ");
        string time = Console.ReadLine(); //"19.01.2014 07:00:00";
        DateTime date = DateTime.ParseExact(time, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                        .AddHours(6.5);
        Console.Write (date.ToString("dd.MM.yyyy HH:mm:ss"));
        Console.WriteLine(" {0}", date.ToString("dddd"),  new CultureInfo("bg-BG"));
    }
}