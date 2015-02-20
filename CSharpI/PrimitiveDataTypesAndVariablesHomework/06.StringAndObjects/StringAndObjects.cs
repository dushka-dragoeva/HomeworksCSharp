using System;

class StringAndObjects
{
    static void Main()
    {
        //6. Strings and Objects
        //Declare two string variables and assign them with Hello and World.
        //Declare an object variable and assign it with the concatenation of 
        //the first two variables (mind adding an interval between).
        //Declare a third string variable and initialize it with the value of 
        //the object variable (you should perform type casting).
        string GreetingOne = "Hello";
        string GreetingTwo ="World";
        object GreetingOneAndTwo = (GreetingOne + " " + GreetingTwo);
        string Greeting = Convert.ToString(GreetingOneAndTwo);
        Console.WriteLine(Greeting);
    }
}
