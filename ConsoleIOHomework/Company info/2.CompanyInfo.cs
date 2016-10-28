using System;

class Company
{
    static void Main()
    {
        Console.WriteLine("Enter Company Name: ");
        string compname = Console.ReadLine();

        Console.WriteLine("Enter Company Address: ");
        string compaddress = Console.ReadLine();

        Console.WriteLine("Enter Phone number: ");
        long phone = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter Fax Number: ");
        string fax = Console.ReadLine();

        Console.WriteLine("Enter Web site: ");
        string web = Console.ReadLine();

        Console.WriteLine("Enter Manager First Name: ");
        string firstname = Console.ReadLine();

        Console.WriteLine("Enter Last Name: ");
        string lastname = Console.ReadLine();

        Console.WriteLine("Enter Manager Age: ");
        byte age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter Manager Phone: ");
        long manphone = long.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("\n {0} \n Address: {1}" +
            " \n Tel.+{2:000 000 00 00 000}", compname, compaddress, phone);

        Console.WriteLine(" Fax: {0}", fax.Length == 0 ? "(no fax)" : fax);
        Console.WriteLine(" Web site: {0} \n" +
            " Manager: {1} {2} (age: {3}, tel. +{4:000 0 000 000}) \n"
            , web,firstname,lastname, age, manphone);

    }
}


