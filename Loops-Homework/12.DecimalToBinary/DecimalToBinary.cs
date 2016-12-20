using System;
//Using loops write a program that converts an integer number to 
//its binary representation.

class DecimalToBinary
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string output = "";

        do
        {
            output = (input % 2 == 0 ? "0" : "1") + output;
            input /= 2;
        } while (input != 0);

        Console.WriteLine(output);

    }
}
