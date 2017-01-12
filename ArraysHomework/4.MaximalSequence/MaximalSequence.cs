using System;

//Write a program that finds the length of the maximal sequence of
// equal elements in an array of N integers.

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter an number n: ");

        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int counter = 1;
        int maxcounter = 1;

        int num = 0; // 

        Console.WriteLine("Enter n integer numbers: ");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = n - 1; i > 0; i--)
        {
            if (arr[i] == arr[i - 1])
            {
                counter++;

                if (counter >= maxcounter)
                {
                    num = arr[i];
                    maxcounter = counter;
                }
            }
            else
            {

                counter = 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine(maxcounter);
        Console.WriteLine(num);
    }
}


