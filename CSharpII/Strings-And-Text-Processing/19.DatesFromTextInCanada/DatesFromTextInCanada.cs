using System;
using System.Text.RegularExpressions;
using System.Globalization;

/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.*/

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "Contact Telerik at 15.03.2015 or 16.02.2015";
        DateTime date;
        foreach (var item in Regex.Matches(text,@"\d+\.\d+\.\d+"))
        {
            string[] dateArr = item.ToString().Split('.');
            date = new DateTime(int.Parse(dateArr[2]), int.Parse(dateArr[1]), int.Parse(dateArr[0]));
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Console.WriteLine(date.ToShortDateString());
        }
    }
}