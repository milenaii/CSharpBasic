using System;
class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;

        while (n >= 1)
        {
            factorial *= n;
            n--;
        }
        Console.WriteLine(factorial);

    }
}

