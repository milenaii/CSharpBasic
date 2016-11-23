using System;

// n ^ m

class Program
{
    static void Main()
    {
        Console.WriteLine("power m = ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("n = " );
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 0; i < m; i++)
        {
            result *= n;
        }
        Console.WriteLine("{0} ^ {1} = {2}", n, m, result);
    }
}
