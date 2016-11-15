using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter three floateger numbers: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        int counter = 0;
        if ((a == 0) || (b == 0) || (c == 0))
        {
            Console.WriteLine(" 0 ");
        }
        else
        {
        

            if (a < 0)
            {
                counter++;
            }
            if (b < 0)
            {
                counter++;
            }
            if (c < 0)
            {
                counter++;
            }

            if ((counter % 2) == 0)
            {
                Console.WriteLine(" + ");
            }
            else if ((counter % 2) != 0)
            {
                Console.WriteLine(" - ");
            }

        }
    }
}

