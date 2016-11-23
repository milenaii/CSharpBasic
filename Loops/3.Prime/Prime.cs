using System;

class Prime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int divise = 2;

        while (divise < n)
        {
            if (n % divise == 0)
            {
            Console.WriteLine("Not prime, because it is divided on {0}", divise);
            divise++;
            }
          
        }
    }
}

