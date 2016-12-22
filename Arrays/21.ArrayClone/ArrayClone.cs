using System;

class ArrayClone
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr2 = (int[])arr.Clone();

          arr[3] = 100;
        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(string.Join(" ", arr2));

    }
}

