using System;

class Exception
{
    static void Main()
    {
        Console.WriteLine("Enter command");
        string command = Console.ReadLine();
        switch (command)
        {
            case "Print":
                Console.WriteLine("Milena");
                break;
            case "Other command":
                Console.WriteLine("Pesho");
                break;

            //default:
             //   throw new Exception();
             // не
        }

    }
}

