using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        //02. A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
        //last name, age and a phone number.
        //Write a program that reads the information about a company and its manager and prints it back on the console.

        string title = "Please enter";
        string companyName = "Company name:";
        string companyAddress = "Company address:";
        string phoneNumber = "Phone number:";
        string faxNumber = "Fax number:";
        string webSite = "Web site:";
        string managerFirstName = "Manager first name:";
        string managerLastName = "Manager last name:";
        string managerAge = "Manager age:";
        string managerPhone = "Manager phone:";
        string formatedText = "{0} {1,-25} ";
        Console.Write(formatedText, title, companyName);
        companyName = Console.ReadLine();
        Console.Write(formatedText, title, companyAddress);
        companyAddress = Console.ReadLine();
        Console.Write(formatedText, title, phoneNumber);
        phoneNumber = Console.ReadLine();
        Console.Write(formatedText, title, faxNumber);
        faxNumber = Console.ReadLine();
        Console.Write(formatedText, title, webSite);
        webSite = Console.ReadLine();
        Console.Write(formatedText, title, managerFirstName);
        managerFirstName = Console.ReadLine();
        Console.Write(formatedText, title, managerLastName);
        managerLastName = Console.ReadLine();
        Console.Write(formatedText, title, managerAge);
        managerAge = Console.ReadLine(); ;
        Console.Write(formatedText, title, managerPhone);
        managerPhone = Console.ReadLine();
        Console.WriteLine("\n{0} \nAdress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age:{7}, tel. {8})",
        companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}