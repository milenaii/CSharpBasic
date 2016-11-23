using System;

class FactorialFor
{
    static void Main()
    {
        int n = 6;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

