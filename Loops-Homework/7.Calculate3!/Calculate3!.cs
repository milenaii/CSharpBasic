using System;
//Write a program that calculates N! / (K! * (N - K)!) for given N and K.
class Calculate3
{
    static void Main()
    {
        Console.WriteLine("Enter N:   1 < N < K < 100 ");
        int n =int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int factcisl = 1;
        int factznam = 1;

        for (int i = k + 1; i <= n; i++)
        {
            factcisl *= i;
        }
        for (int i = 1; i <= n-k; i++)
        {
            factznam *= i;
        }
        Console.WriteLine(factcisl/factznam);
    }
}

