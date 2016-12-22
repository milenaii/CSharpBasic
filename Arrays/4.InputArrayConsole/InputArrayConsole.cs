using System;

class InputArrayConsole
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] num = new int[n];

        for (int i = 0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        // Lets sum the elements of array

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += num[i];
            //Console.WriteLine(sum); може и да е в цикъла
        }
        Console.WriteLine("The sum of elements of array is: " + sum + "\n");
    }
}

