using System;

class NestedLoops
{
    static void Main()
    {
        for (int j = 1; j < 8; j++)
        {
            for (int i = 1; i <= j; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }

    }
}

