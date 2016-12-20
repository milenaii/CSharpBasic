using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number:");
        int n = int.Parse(Console.ReadLine());

        double a;
        double sum = 0;

        for (int i = 1; i < n; i++)
        {
            a = n / (Math.Pow(5, i));
            sum += a;

            if (a <= 5)
            {
                Console.WriteLine(sum);
                break;
            }
        }
    }
}
