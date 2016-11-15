using System;

//Write a program that finds the biggest of three numbers that are read from the console.

class BiggestOf3
{
    static void Main()
    {
        Console.WriteLine("Enter three real numbers: ");

        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine(a);
            }
            else if (a < c)
            {
                Console.WriteLine(c);
            }
        }

        else if (b >= c)
        {
            if (b >= a)
            {
                Console.WriteLine(b);
            }
            else if (b < a)
            {
                Console.WriteLine(a);
            }
        }
        else if (c >= a)
        {
            if (c >= b)
            {
                Console.WriteLine(c);
            }
            else if (c < b)
            {
                Console.WriteLine(b);
            }
        }

    }
}

