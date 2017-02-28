using System;
using System.Numerics;


//find the average feathers count per bird
// if b -> even *= 123123123123;
//if b -> odd /= 317;  
class BirdsAndFeathers
{
    static void Main()
    {
        decimal b = decimal.Parse(Console.ReadLine()); // birds in the forest
        decimal f = decimal.Parse(Console.ReadLine()); // feathers in the forest

        if (b == 0 && f == 0)
        {
            goto final;
        }

        decimal meven = 123123123123;
        decimal modd = 317;
        decimal fb = f / b;

        if (b % 2 == 0)
        {
            fb *= meven;
        }
        else if (b % 2 == 1)
        {
            fb /= modd;
        }
        Console.WriteLine("{0:0.0000 }", fb);

        final:
        Console.WriteLine("0.0000");

        Console.WriteLine();
    }
}

