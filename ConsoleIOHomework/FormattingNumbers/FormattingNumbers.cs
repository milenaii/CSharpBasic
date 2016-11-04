using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: 0 <= a <= 500 ");
        int a = int.Parse(Console.ReadLine());

        if (0 <= a && a <= 500)

        {
            Console.WriteLine("Enter float number: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter float number: ");
            float c = float.Parse(Console.ReadLine());

            //Console.WriteLine("{0:X}", a);
            //Console.WriteLine(Convert.ToString(a, 2).PadLeft(10, '0'));
            //Console.WriteLine("{0,10:0.00}", b);
            //Console.WriteLine("{0,-10:0.000}", c);

            string ad = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("{0:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", a, ad, b, c);

        }

        else
        {
            Console.WriteLine("Incorrect number:");

        }
    }
}

