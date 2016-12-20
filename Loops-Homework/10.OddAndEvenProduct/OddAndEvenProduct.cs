using System;

class OddAndEvenProduct
{
    static void Main()
    {

        Console.WriteLine("Enter n:    4 <= n <= 50 ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter n integer numbers: ");
        string[] num = Console.ReadLine().Split();

        int evenprod = 1;
        int oddprod = 1; 

        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenprod  *= Convert.ToInt32(num[i]);
            }
            else
            {
                oddprod *= Convert.ToInt32(num[i]);
            }

        }

        if (oddprod == evenprod)
        {
            Console.WriteLine("yes" + oddprod);
        }
        else
        {
            Console.WriteLine("no {0} {1}",oddprod, evenprod);
        }
        


    }
}

