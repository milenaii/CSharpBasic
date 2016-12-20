using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n: 0 <= n <= 100");
        ulong n = ulong.Parse(Console.ReadLine());

        ulong nfact = 1;
        ulong n2donplus2 = 1;

        for (ulong i = 1; i <= n; i++)
        {
            nfact *= i;
        }
        for (ulong i = n + 2; i <= 2*n; i++)
        {
            n2donplus2 *= i;
        }
        Console.WriteLine(n2donplus2/nfact);
    }
}

