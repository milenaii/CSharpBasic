using System;
//Write a program that finds all prime numbers in the range [1 ... N].
//Use the Sieve of Eratosthenes algorithm. The program should print the
//biggest prime number which is <= N.

// info - algorithm https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        bool[] A = new bool[n+1];

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (A[i] == true)
            {
                for (int j = i * i; j < n; j = j + i)
                {
                    A[j] = false;
                }
            }
        }
        //This code prints all prime numbers from 1 up to n

        //for (int i = 0; i < n; i++)
        //{
        //    if (A[i] == true)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        for (int i = n ; i >= 2; i--)   // prints the biggest
        {                                  // of prime numbers
            if (A[i] == true)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}