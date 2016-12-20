using System;

class CalcAg
{
    static void Main()
    {
        Console.WriteLine("Enter N:   1 < N < K < 100 ");
        int n = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = byte.Parse(Console.ReadLine());

        int result = 1;
        // result = nfact/kfact    razpishi!!
        //n! = n * n-1 * n-2 * n-3....k * k-1 * k-2 * k-3....1
        //k! = k * k-1 * k-2 * k-3 ....1
        // съкръщават се и остава от k+1 до n
        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}

