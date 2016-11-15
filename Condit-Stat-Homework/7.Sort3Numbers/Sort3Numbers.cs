using System;

//Write a program that enters 3 real numbers and prints them 
//sorted in descending order.

    class Sort3Numbers
    {
        static void Main()
        {
        Console.WriteLine("Enter three real numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if ((- 1000 < a) && (a < 1000) && (-1000 < b) 
            && (b < 1000) && (-1000 < c) && (c < 1000))
        {

            if (a >= b)
            {
                if (a >= c)
                {
                    if (b >= c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, b, c);
                    }
                    else if (c > b)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                }
                else if (c > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
            else if (b > a)
            {
                if (b >= c)
                {
                    if (a >= c)
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
                    else if (c > a)
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                }
                else if (c > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }

        }
        else
        {
            Console.WriteLine("Not value number or numbers!");
        }
    }
}

