using System;
class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;

        do
        {
            factorial *= n;
            n--;
        } while (n > 1);

        Console.WriteLine(factorial);

    }
}

