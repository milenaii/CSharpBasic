using System;
//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the Selection sort algorithm:
//Find the smallest element, move it at the first position, find the
//smallest from the rest, move it at the second position, etc.
class SelectionSort2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1 ; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (array[i] > array[j])
                {
                    int hp = array[i];
                    array[i] = array[j];
                    array[j] = hp;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

