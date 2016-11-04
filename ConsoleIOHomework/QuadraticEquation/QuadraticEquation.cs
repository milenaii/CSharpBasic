﻿using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).
//Input
//On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order
//Output
//If two different real roots exist, print them on two separate lines
//Print the smaller root on the first line
//If only one real root exists, print it on the only output line
//If no real root exists, print the string "no real roots"
//The roots, should they exist, must be printed with precision exactly two digits after the floating point

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter real numbers a,b,c: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        float d = (b * b) - (4 * a * c);
        //Console.WriteLine(d);

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }

        else
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);

            if (x1 == x2)
            {
                
                Console.WriteLine("{0:0.00}", x1);
            }

            if (x1 < x2)
            {
                Console.WriteLine("{0:0.00} \n{1:0.00}", x1,x2);
            }
            if (x1 > x2)
            {
                Console.WriteLine("{0:0.00} \n{1:0.00}", x2, x1);
            }
              
        }

    }
}

