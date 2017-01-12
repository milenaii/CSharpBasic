using System;

//

class SelectionSort
{
    static void Main()
    {
        int[] arr = new int[] { 6, 2, 5, 4, 1, 3 };
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    int hp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = hp;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
}

