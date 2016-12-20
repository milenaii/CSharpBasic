using System;
//ne Mimi
class CalcAgain
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int rezult = 1;

        for (int i = n; n > k; n--)
        {
            rezult *= n;
        }
        Console.WriteLine(rezult);
    }
}

