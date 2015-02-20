using System;

class QuotesAndStrings
{
    static void Main()
    {
        
        //7. Quotes in Strings
        //Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
        //Do the above in two different ways - with and without using quoted strings.
        //Print the variables to ensure that their value was correctly defined.
        string StringOne ="The \" Use \" of quotations causes difficults ";
        string StringTwo = @"The "" Use "" of quotations causes difficults ";
        Console.WriteLine(StringOne);
        Console.WriteLine(StringTwo);
    }
}