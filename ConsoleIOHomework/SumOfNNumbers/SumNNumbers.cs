using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if ((-1000 > a)^(a > 1000))
            {
                Console.WriteLine("Not valid number!");
            }
            else
            sum = sum + a;

        }
            Console.WriteLine("The sum is: {0} \n", sum);
    }
}

