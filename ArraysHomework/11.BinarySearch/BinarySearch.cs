using System;
//Write a program that finds the index of given element X in a sorted
//array of N integers by using the Binary search algorithm.
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter an n integer numbers: ");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter x:");
        int x = int.Parse(Console.ReadLine());

        int l = 0;
        int r = n - 1;
        int middle;

        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            middle = (l + r) / 2;

            if (x == arr[i])
            {
                Console.WriteLine(i);
                found = true;
                break;
            }
            else if (x < arr[i])
            {
                r = middle;
            }
            else if (x > arr[i])
            {
                l = middle;
            }
        }
        if (found == false)
        {
            Console.WriteLine(-1);
        }
    }
}
