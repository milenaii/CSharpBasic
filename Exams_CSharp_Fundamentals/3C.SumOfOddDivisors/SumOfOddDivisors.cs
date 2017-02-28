using System;
//Odd divisors sum is called the sum of all odd divisors of a given integer.
//For example: 6 has 4 divisors(1, 2, 3 and 6) but only 1 and 3 of them
// are odd, so the sum of all odd divisors of 6 is 4.
//You are given 2 numbers: A and B.For each number in the 
//interval A, B sum the sum of their odd divisors.

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0 && j % 2 != 0)
                {
                    sum += j;
                }
            }
        }
        Console.WriteLine(sum);

    }
}

