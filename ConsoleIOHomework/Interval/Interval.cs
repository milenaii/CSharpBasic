using System;

class Interval
{
    static void Main()
    {
        Console.WriteLine("Enter two integer positive number: ");
        uint n = uint.Parse(Console.ReadLine());
        uint m = uint.Parse(Console.ReadLine());
        if (!(0 <= n) ^ !(n <= m) ^ !(m <= 2000))
        {
            Console.WriteLine("Not valid numbers!");
        }
        else
        {
            uint a = (m - n) / 5;
            Console.WriteLine(a);
        }
    }
}

