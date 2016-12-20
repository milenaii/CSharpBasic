using System;
//Write a program that calculates the greatest common divisor
//(GCD) of given two integers A and B.

class GCD
{
    static void Main()
    {
        Console.WriteLine("Enter two integers, separated by a whitespace:  [2, 500]");
        string[] num = Console.ReadLine().Split(' ');

        int a = int.Parse(num[0]);
        int b = int.Parse(num[1]);

        if ((a < 2) || (a > 500) || (b < 2) || (b > 500))
        {
            Console.WriteLine("Not valid number!");
        }
        else
        {


            int biggest;
            int smaller;
            int res;

            if (a > b)
            {
                biggest = a;
                smaller = b;
            }
            else
            {
                biggest = b;
                smaller = a;
            }

            do
            {
                res = biggest % smaller;

                if (res == 0)
                {
                    Console.WriteLine(smaller);
                    break;
                }
                biggest = smaller;
                smaller = res;
            }
            while (res != 0);
            Console.WriteLine(smaller);
        }

    }
}


