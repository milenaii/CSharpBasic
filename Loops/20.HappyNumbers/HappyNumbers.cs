using System;

class HappyNumbers
{
    static void Main()
    {
        for (int a = 1; a <= 9; a++)
            for (int b = 0; b <= 9; b++)
                for (int c = 0; c <= 9; c++)
                    for (int d = 0; d <= 9; d++)
                    {
                        if (a + b == c + d)
                        {
                            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                        }
                    }
        // 2 way - with 3 loops


        //for (int a = 1; a <= 9; a++)
        //    for (int b = 0; b <= 9; b++)
        //        for (int c = 0; c <= 9; c++)
        //        {
        //            var d = a + b - c;
        //            if (0 <= d && d <= 9)
        //            {
        //                Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
        //            }
        //        }

    }
}


