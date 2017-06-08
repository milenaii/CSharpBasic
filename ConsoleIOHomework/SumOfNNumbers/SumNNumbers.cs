using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number N: ");
        int N = int.Parse(Console.ReadLine());
        if (!(1 <= N) ^ !(N <= 200))
        {
            Console.WriteLine("Not valid number N!");
        }
        else
        {
            float sum = 0.0F;
            for (int i = 0; i < N; i++)
            {
                float num = float.Parse(Console.ReadLine());
                if (!(-1000 <= num) ^ !(num <= 1000))
                {
                    Console.WriteLine("Not valid number!");
                    break;
                }
                else
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

