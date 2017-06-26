using System;
//Write a program that reads an array of integers and
//removes from it a minimal number of elements in such a way
//that the remaining array is sorted in increasing order. 
//Print the minimal number of elements that need to be removed
// in order for the array to become sorted.

//https://www.youtube.com/watch?v=fsCLjcZwfhY

// единият тест не излиза

class RemoveElementsFromArray
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter n:");
        int l = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter n integer numbers:");
        int[] A = new int[l];
        for (int i = 0; i < l; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }

        int max = 0;

        // LIS - longest increasing subsequence - initialise with 1
        int[] LIS = new int[l];

        for (int i = 0; i < l; i++)
        {
            LIS[i] = 1;
        }

        for (int i = 1; i < l; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (A[i] > A[j] && LIS[i] < LIS[j] + 1)
                {
                    LIS[i] = LIS[j] + 1;
                }
            }
        }
        for (int i = 0; i < l - 1; i++)
        {
            if (LIS[i] < LIS[i + 1])
            {
                max = LIS[i + 1];
            }
        }
        Console.WriteLine();
        Console.WriteLine(l - max);
    }
}

