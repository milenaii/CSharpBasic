using System;

class NdoM
{
    static void Main()
    {
        // n > m
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter m > n: ");
        int m = int.Parse(Console.ReadLine());

        if (n < m)
        {

            int i = n;
            int product = 1;

            do
            {
                product = product * i;
                i++;
            } while (i <= m);

            Console.WriteLine("Product n...m = " + product);
        }
        else
        {
            Console.WriteLine("Error! n != m");
        }
    }
}

