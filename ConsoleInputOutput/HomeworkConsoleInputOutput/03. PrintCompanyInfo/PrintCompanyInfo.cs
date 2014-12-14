using System;
// A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
// last name, age and a phone number. Write a program that reads the information about a company and its
// manager and prints them on the console.

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Please enter The Company Name: ");
        string compName = Console.ReadLine();
        Console.Write("Please enter The Company Address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Please enter The Company Phone number: ");
        string compPhone = Console.ReadLine();
        Console.Write("Please enter The Company Fax number: ");
        string compFax = Console.ReadLine();
        Console.Write("Please enter The Company Web Site: ");
        string compWeb = Console.ReadLine();

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");

        Console.Write("Please enter The Manager First name: ");
        string mFirstName = Console.ReadLine();
        Console.Write("Please enter The Manager Second name: ");
        string mSecondName = Console.ReadLine();
        Console.Write("Please enter The Manager Age: ");
        byte mAge = byte.Parse(Console.ReadLine());
        Console.Write("Please enter The Manager Phone number: ");
        string mPhone = Console.ReadLine();

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");

        Console.WriteLine("Company {0} details:\nAddress: {1}\nPhone Number: {2}\nFax Number: {3}" + 
            "\nWeb Site: {4}", compName, compAddress, compPhone, compFax, compWeb);

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - ");

        Console.WriteLine("Manager details:\nFull Name: {0} {1}\nAge: {2}\nPhone Number: {3}",
            mFirstName, mSecondName, mAge, mPhone);
    }
}

