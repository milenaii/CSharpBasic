using System;
//Using loops write a program that converts a hexadecimal integer
//number to its decimal form.

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter Hexadecimal integer number: ");
        string hex = Console.ReadLine();

        int pow = 1;
        long sum = 0;

        for (int i = 0; i < hex.Length ; i++)
        {
            switch (hex[hex.Length - 1 - i])
            {
                case '0':
                    pow = 0 * (int)Math.Pow(16, i);
                    break;
                case '1':
                    pow = 1 * (int)Math.Pow(16, i);
                    break;
                case '2':
                    pow = 2 * (int)Math.Pow(16, i);
                    break;
                case '3':
                    pow = 3 * (int)Math.Pow(16, i);
                    break;
                case '4':
                    pow = 4 * (int)Math.Pow(16, i);
                    break;
                case '5':
                    pow = 5 * (int)Math.Pow(16, i);
                    break;
                case '6':
                    pow = 6 * (int)Math.Pow(16, i);
                    break;
                case '7':
                    pow = 7 * (int)Math.Pow(16, i);
                    break;
                case '8':
                    pow = 8 * (int)Math.Pow(16, i);
                    break;
                case '9':
                    pow = 9 * (int)Math.Pow(16, i);
                    //pow = hex[hex.Length - 1- i] * (int)Math.Pow(16, i);
                    // така не става, честно казано не разбирам защо
                    break;
                case 'A':
                    pow = 10*(int)Math.Pow(16, i);
                    break;
                case 'B':
                    pow = 11 * (int)Math.Pow(16, i);
                    break;
                case 'C':
                    pow = 12 * (int)Math.Pow(16, i);
                    break;
                case 'D':
                    pow = 13 * (int)Math.Pow(16, i);
                    break;
                case 'E':
                    pow = 14 * (int)Math.Pow(16, i);
                    break;
                case 'F':
                    pow = 15 * (int)Math.Pow(16, i);
                    break;
                default:
                    Console.WriteLine("Not valid hexadecimal number!");
                    break;
            }
                    sum += pow;
        }
                    Console.WriteLine(sum);
    }
}

