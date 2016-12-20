using System;
//Using loops write a program that converts a binary integer number
// to its decimal form.

class BinaryToDecimal
{
    static void Main()

    {

        Console.WriteLine("Enter an integer number representation in binary:");

        string binary = Console.ReadLine();

        int power = 1;

        long number = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - 1 - i] == '0')
            {
                continue;
            }
            else
            {
                power *= (int)Math.Pow(2, i);
                number += power;
            }
        }
        Console.WriteLine(number);

    }
}

