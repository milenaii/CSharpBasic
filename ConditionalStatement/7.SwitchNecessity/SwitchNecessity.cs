using System;

class SwitchNecessity
{
    static void Main()
    {
        int telenor = int.Parse(Console.ReadLine());

        if (telenor == 1)
        {
            Console.WriteLine("Info smetka");
        }
        else if (telenor == 2)
        {
            Console.WriteLine("Razplashtanija");
        }
        else if (telenor == 3)
        {
            Console.WriteLine("Roaming");
        }
        // и така нататък - много повторения, затова е по-добре switch-case
        // виж 8.SwitchCase
    }
}

