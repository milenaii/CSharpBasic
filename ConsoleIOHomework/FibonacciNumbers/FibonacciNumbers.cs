using System;

class FibonacciNumbers
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //int a = 0;
        //int b = 1;
        //    Console.Write("0,1,");
        //for (int i = 1; i < ((n/2)-2); i++)
        //{ 
        //    a = a + b;
        //    b = a + b;
        //    Console.Write("{0},{1},", a, b);
        //}


        int n = int.Parse(Console.ReadLine());
        for (uint i = 0, a = 0, b = 1; i < n; i++, a = a + b, b = a - b)
        {
            Console.Write(a + ", ");
            Console.WriteLine(b);

        //i = 0, a = 0, b = 1;
        //i = 1, a = 1, b = 0; 
        //i = 2, a = 1, b = 1;
        //i = 3, a = 2, b = 1;
        //i = 4, a = 3, b = 2;

        //или b = на настоящето а - миналото b
        //        b e последното число
        //        а е сборът, т.е. новото число
        //    a + b = най-новото


        //Трети начин
        //                    Console.Write("Enter a number N for range: ");
        //    BigInteger n = BigInteger.Parse(Console.ReadLine());
        //    BigInteger firstNum = 0;
        //    BigInteger secondNum = 1;
        //    BigInteger thirdNum = 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        thirdNum = secondNum;
        //        secondNum = firstNum + secondNum;
        //        firstNum = thirdNum;
        //        Console.Write(firstNum + " ");
        //    }
        //    Console.ReadLine();


    }




