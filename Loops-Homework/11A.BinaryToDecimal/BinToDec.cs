using System;

class BinToDec
{
    static void Main()
    {
        string binary = Console.ReadLine();
        
        long dec = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - 1 - i] == '0')
            {
                continue;
            }
            else
            {
                dec += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(dec);
    }
}