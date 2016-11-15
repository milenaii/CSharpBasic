using System;

//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 5 floating-point numbers: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = float.Parse(Console.ReadLine());

        if ((-200 <= a) && (a <= 200) && (-200 <= b) &&
            (b <= 200) && (-200 <= c) && (c <= 200) && 
            (-200 <= d) && (d <= 200) && (-200 <= e) && (e <= 200))

        {

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine(a);
            }
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine(b);
            }
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine(c);
            }
            else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine(d);
            }
            else if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine(e);
            }

        }
        else if (!(-200 <= a) || !(a >= 200) || !(-200 <= b) || (b >= 200) || !(-200 <= c) || !(c >= 200) || !(-200 <= d) || !(d >= 200) || !(-200 <= e) || !(e >= 200))
        {
        Console.WriteLine("Not valid number or numbers!");
        }

    }
}


