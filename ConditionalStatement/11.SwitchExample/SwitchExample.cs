using System;

    class SwitchExample
    {
        static void Main()
        {
        string animal = Console.ReadLine();
        switch (animal)
        {
            case "dog":
                Console.WriteLine("MAMMAL");
                break;

            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("REPTILE");
                break;
            default:
                Console.WriteLine("There is no such animal");
                break;
        }
    }
    }

