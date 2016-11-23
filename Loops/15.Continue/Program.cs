using System;

// Print without these who are dividible on 5 or 7

class Program
{
    static void Main()
    {
        int n = 50;
        for (int i = 0; i < n; i++)
        {
            if (i % 7 == 0 || i % 5 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        // по-смислено можем да разпишем пимера така:

        int m = 50;
        for (int i = 0; i < n; i++)
        {
            if (!(i % 7 == 0 || i % 5 == 0)) // обратният if на горния
            {
            Console.WriteLine(i); // cw влиза в if
            }
        }
    }
}

