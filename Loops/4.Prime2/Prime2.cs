using System;

class Prime2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int divise = 2;

        bool isPrime = true;

        while (divise < n)
        {
            if (isPrime && (n % divise == 0))
            {
                Console.WriteLine("Not prime, because it is divided on {0}", divise);
                // това cw може да е най- след while
                isPrime = false;
            }
            divise++;

        }
        Console.WriteLine(isPrime ? "{0} is Prime" : "{0} is not prime", n);

    }
}

