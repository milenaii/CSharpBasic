using System;
// изчисленията са ок, в единият пример дава грешка, защото
// не взема най-добрия комб - тр да се погледне
class BoboAvokadoto
{
    static void Main()
    {
        Console.WriteLine("Enter an integer n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an integer c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c integers: ");

        int comb = 0;
        int bestComb = 0;

        for (int j = 0; j < c; j++)
        {
            int currentComb = int.Parse(Console.ReadLine());

            //get
            for (int i = 0; i < 32; i++)
            {
                int mask = (1 << i);
                int getn = n & mask;
                int getcurrentComb = currentComb & mask;

                if ((getn > 0) & (getcurrentComb > 0))
                {
                    break;
                }

                if ((getn == 0) & (getcurrentComb > 0))
                {
                    comb++;
                }
            }
            if (comb > bestComb)
            {
                bestComb = currentComb;
                comb = 0;
            }
        }
        Console.WriteLine(bestComb);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(Convert.ToString(9, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(1, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(2, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(3, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(6, 2).PadLeft(32, '0'));

    }
}
