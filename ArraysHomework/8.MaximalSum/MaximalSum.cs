using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        int temp = 0;
        int sum = 0;

        Console.WriteLine("Enter an n numbers: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());       
        }

        for (int i = 0; i < n; i++)
        {
            temp = arr[i];
            for (int j = i + 1; j < n; j++)
            {
                temp = temp + arr[j];
                if (temp > sum)
                {
                    sum = temp;
                }
            } 
        }
        Console.WriteLine(sum);
    }
}
