using System;
using System.Numerics;

//Write a program that calculates N! / (K! * (N - K)!) for given N and K.

class Calc3
{
    static void Main()
    {
        Console.WriteLine("Enter N:   1 < N < K < 100 ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger nfact = 1;
        BigInteger kfact = 1;
        BigInteger nkfact = 1;

        for (int i = 1; i <= n; i++)
        {
            nfact *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            kfact *= i;
        }
        for (int i = 1; i <= n-k ; i++)
        {
            nkfact *= i;
        }
        
        Console.WriteLine(nfact/(kfact*nkfact));
    }
}

