using System;
//Write a program that calculates N! / K! for given N and K.

class CalculateAgain
{
    static void Main()
    {
        Console.WriteLine("Enter N:   1 < N < K < 100 ");
        int n = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = byte.Parse(Console.ReadLine());

        int nfact = 1;
        int kfact = 1;

        for (int i = 1; i <= n; i++)
        {
            nfact *= i;
        }
        for (int j = 1; j <= k; j++)
        {
            kfact *= j;
        }
        //Console.WriteLine(nfact);
        //Console.WriteLine(kfact);

        Console.WriteLine((nfact/kfact));
    }
}

