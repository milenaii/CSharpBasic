using System;

class SymmetricArray
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 1 };
        //int[] numbers = { 1, 2, 3, 4, 5 };

        int n = numbers.Length;

        // n-1 e последният член

        bool symmetric = true;
        for (int i = 0; i < n - 1; i++)
        // i < (n-1-i) , т.е ако сме проверили до половината е излишно да продължаваме 
        {
            // нулевият индекс дали е = на последния, първия ?= предпоследния и т.н.
            if (numbers[i] != numbers[n - 1 - i])
            {
                symmetric = false;
                break;
                // ако за една двойка не е вярно - няма нужда повече да се проверява - не е симетр
                // ако е вярно тр да се провери и за другите
            }

        }
        if (symmetric == true)
        {
            Console.WriteLine("Array is symmetric");
        }
        else
        {
            Console.WriteLine("Array is not symmetric");

        }

    }
}

