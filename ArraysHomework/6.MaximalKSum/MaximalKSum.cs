using System;

//Write a program that reads two integer numbers N and K
//and an array of N elements from the console. Find the maximal
//sum of K elements in the array.

class MaximalKSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        int sumk = 0;

        Console.WriteLine("Enter n integer numbers: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++) // колко обхождания
        {
            for (int j = 0; j < n - 1; j++) // сравнявания по двойки
            {
                if (arr[j] > arr[j + 1])
                {
                    int tmp = arr[j];     // swap the elements
                    arr[j] = arr[j + 1];  //
                    arr[j + 1] = tmp;  // 
                }
            }
        }
        for (int i = 1; i <= k; i++)
        {
            sumk = sumk + arr[n - i];
        }
        Console.WriteLine(sumk);
    }
}

