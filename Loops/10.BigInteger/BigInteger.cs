using System;
using System.Numerics;


// You can try with n = 15, 25, 100 but not very big n - the program wll be troubled!!!

class BigIntegerrrrr
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        while (n >= 1)
        {
            factorial = factorial * n;
            n--;
        }
        Console.WriteLine(factorial);

    }
}

