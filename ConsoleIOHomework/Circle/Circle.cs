using System;


    class Circle
    {
        static void Main()
        {
        Console.WriteLine("Enter radius of circle");

        double r = double.Parse(Console.ReadLine());
        double p = Math.PI * r * 2;
        double s = Math.PI * r * r;

        Console.WriteLine("{0:00.00} {1:00.00}",p, s);

        }
    }

