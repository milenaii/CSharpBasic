using System;
//Write a program that finds in given array of integers 
//a sequence of given sum S (if present).
class FindSUmInArray
{
    static void Main()
    {
        Console.WriteLine("Enter integer n:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter an n integers: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter integer x: ");
        int x = int.Parse(Console.ReadLine());

        int l = 0;
        int r = n;

        bool found = false;

        for (int i = 0; i < n; i++)
        {

            int middle = (l + r) / 2;

            if (x == arr[middle])
            {
                found = true;
                Console.WriteLine(middle);
                break;
            }
            else if (x > arr[middle])
            {
                l = middle;
            }
            else if (x < arr[middle])
            {
                r = middle;
            }
        }
        if (found == false)
        {
            Console.WriteLine(-1);
        }
    }
}

