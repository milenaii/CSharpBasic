using System;
//Write a program that reads from the console a positive integer
// number N and prints a matrix like in the examples below.
// Use two nested loops.

class MatrixOfNumbers
{
    // Браво Мими!
    static void Main()
    {
        Console.WriteLine("Enter n:    1 <= n <= 20 ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i + n - 1; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }


    }
}

