using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday(DD/MM/YYYY):");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        DateTime today = DateTime.Today;
        int age = 0;
        if (today.Month < birthday.Month)
        {
            age = today.Year - birthday.Year - 1;
            Console.WriteLine("Your are {0} years old", age);
            Console.WriteLine("Your will be {0} years old after 10 years", (age + 10));
        }
        else if (today.Month > birthday.Month)
        {
            age = today.Year - birthday.Year;
            Console.WriteLine("Your are {0} years old", age);
            Console.WriteLine("Your will be {0} years old after 10 years", (age + 10)); 
        }
        else
        {
            if (today.Day < birthday.Day)
            {
                age = today.Year - birthday.Year - 1;
                Console.WriteLine("Your are {0} years old", age);
                Console.WriteLine("Your will be {0} years old after 10 years", (age + 10));
            }
            else
            {
                age = today.Year - birthday.Year;
                Console.WriteLine("Your are {0} years old", age);
                Console.WriteLine("Your will be {0} years old after 10 years", (age + 10));
            }
        }
    }
}

