using System;

class NumberCompare
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them.

        Console.WriteLine("Enter two real numbers:");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(a);
        }

        else { Console.WriteLine(b); }

    }
}

