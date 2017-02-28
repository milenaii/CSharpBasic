using System;
class Trysmth
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine(1);
                        break;
                    case 2:
                        Console.WriteLine(2);
                        break;
                    case 3:
                        Console.WriteLine(3);
                        break;

                    default:
                        break;
                }

            }
            for (int j = 1; j < 4; j++)
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine(22);
                        break;
                    case 2:
                        Console.WriteLine(22);
                        break;
                    case 3:
                        Console.WriteLine(22);
                        break;
                    default:
                        break;
                }
            }

        }

    }
}

