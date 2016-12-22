using System;

class ReverseArray
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] reverseNumbers = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            reverseNumbers[i] = numbers[numbers.Length - 1 - i];
            Console.WriteLine(reverseNumbers[i]);
        }

    }
}

