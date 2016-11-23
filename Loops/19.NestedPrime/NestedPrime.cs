using System;

class NestedPrime
{
    static void Main()
    {
        int left = 10;
        int right = 60;

        while (left < right)
        {
            int n = left;
            int divise = 2;

            bool isPrime = true;

            while (divise < n)
            {
                if (isPrime && (n % divise == 0))
                {
                    Console.WriteLine("Not prime, because it is divided on {0}", divise);
                    isPrime = false;
                }
                divise++;

            }
            Console.WriteLine(isPrime ? "{0} is Prime" : "{0} is not prime", n);
            left++;  // aко го няма това цикълът е безкраен
        }
    }
}

