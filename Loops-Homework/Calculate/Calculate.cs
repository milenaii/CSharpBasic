using System;
//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter N:   2 <= N <= 10 ");
        byte N = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter x:   0.5 <= x <= 100 ");
        float x = float.Parse(Console.ReadLine());

        float xpow = 1;
        float Nfact = 1;

        float s = 1;

        for (int i = 1; i <= N; i++)
        {
            Nfact = Nfact * i;
            //Console.WriteLine("Nfact" + Nfact);

            xpow *= x;
            //Console.WriteLine("xpow" + xpow);

            s = s + (Nfact / xpow);
        }
        Console.WriteLine("{0:0.00000}",s);

    }
}

