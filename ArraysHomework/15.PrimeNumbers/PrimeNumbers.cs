using System;
//Write a program that finds all prime numbers in the range [1 ... N].
//Use the Sieve of Eratosthenes algorithm. The program should print the
//biggest prime number which is <= N.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int divise = 2;
        for (int i = 2; i <= n; i++)
        {
            if (n % divise == 0)
            {
                Console.WriteLine("{0} is not prime, b/e it is devided on {1}",n, divise);
                divise++;
            }
            else
            {
                Console.WriteLine("prime");
            }
        }
    }
}

