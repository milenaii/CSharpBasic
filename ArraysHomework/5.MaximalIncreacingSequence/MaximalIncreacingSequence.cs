using System;

//Write a program that finds the length of
//the maximal increasing sequence in an array of N integers.

class MaximalIncreacingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        int counter = 1;
        int maxcounter = 1;

        Console.WriteLine("Enter n integer numbers: ");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i+1] == arr[i]+1)
            {
                counter++;

                if (counter > maxcounter)
                {
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
    }
}


