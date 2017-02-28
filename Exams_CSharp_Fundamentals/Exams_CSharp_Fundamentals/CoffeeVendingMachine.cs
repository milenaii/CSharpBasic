using System;
using System.Globalization;
using System.Threading;

class CofeeVendingMachine

{
    static void Main()
    {

        // Ensure the decimal separator is ".", not "," or any other

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;



        Console.WriteLine("Enter N1 - numbers of coins available 0.05 lv:");
        int N1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter N2 - numbers of coins available 0.10 lv:");
        int N2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter N3 - numbers of coins available 0.20 lv:");
        int N3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter N4 - numbers of coins available 0.50 lv:");
        int N4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter N5 - numbers of coins available 1.00 lv:");
        int N5 = int.Parse(Console.ReadLine());

        Console.WriteLine("Entet the amount A of money the developer has put into the machine: ");
        decimal A = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter the prise P of the selected drink: ");
        decimal P = decimal.Parse(Console.ReadLine());

        // How money there are in the machine N:
        decimal N = N1 * 0.05M + N2 * 0.10M + N3 * 0.20M + N4 * 0.50M + N5 * 1.00M;

        if (A > P)
        {
            if (N >= A)
            {
                Console.WriteLine("Yes " + (N- (A - P)));
                // money left in the machine after giving change
            }
            else if (N < A)
            {
                Console.WriteLine("No " + ((A - P) - N));
                //amount of insuffisient money in the machine
            }
        }
        else if (A < P)
        {
            Console.WriteLine("More " + (P - A));
            // additional amount of money needed
        }


    }
}//end

