using System;

// Тук копираме само референцията, адреса, без елементите

class AdressArrayClone
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr2 = arr;

        arr[3] = 100;
        Console.WriteLine(string.Join(" ",arr));
        Console.WriteLine(string.Join(" ", arr2));

    }
}

