using System;
//сумиране на всички числа от 1 до N

class Sum1N
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        int count = 1;

        while (count <= n)
        {
            sum = sum + count;
            count++;
        }

        Console.WriteLine(sum);
    }
}

