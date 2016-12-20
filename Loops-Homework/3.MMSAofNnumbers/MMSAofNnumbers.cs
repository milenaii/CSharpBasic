using System;
//Write a program that reads from the console a sequence of N real numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).

class MMSAofNnumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        float sum = 0;
        float ave = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            min = Math.Min(min, num);
            max = Math.Max(max, num);
            sum += num;
            ave = sum / n;
        }
        Console.WriteLine("min={0:0.00}\nmax={1:0.00}\nsum={2:0.00}\navg={3:0.00}", min, max, sum, ave);

    }
}

