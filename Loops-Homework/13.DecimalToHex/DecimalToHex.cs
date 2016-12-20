using System;
//Using loops write a program that converts an integer number 
//to its hexadecimal representation.

class DecimalToHex
{
    static void Main()
    {
        Console.WriteLine("Enter integer in decimal numerical system: long");
        long input = long.Parse(Console.ReadLine());
        string output = "";

        do
        {
            switch (input % 16)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    output = input % 16 + output;
                    break;
                case 10:
                    output = "A" + output;
                    break;
                case 11:
                    output = "B" + output;
                    break;
                case 12:
                    output = "C" + output;
                    break;
                case 13:
                    output = "D" + output;
                    break;
                case 14:
                    output = "E" + output;
                    break;
                case 15: 
                    output = "F" + output;
                    break;
            }
            input /= 16;
        } while (input != 0);

        Console.WriteLine(output);

    }
}

