using System;

class Program
{
    static void Main()
    {
        int outerCounter = 0;
        for (int outer = 0; outer < 10; outer++)
        {
            for (int inner = 0; inner < 10; inner++)
            {
                if (inner % 3 == 0)
                {
                    continue;
                }
                if (inner == 7)
                {
                    break;
                }
                if (inner + outer > 9)
                {
                    goto breakOut;
                }
                //Console.WriteLine("{0} {1}", outer, inner);
            }
            outerCounter++;
            //Console.WriteLine(outerCounter);
        }
        breakOut:
        { }
    }
}
