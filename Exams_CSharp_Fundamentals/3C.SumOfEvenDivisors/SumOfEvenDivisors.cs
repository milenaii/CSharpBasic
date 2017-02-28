using System;
//Even divisors sum is called the sum of all even divisors of a given integer.
//For example: 6 has 4 divisors(1, 2, 3 and 6) but only 2 and 6 of them are 
//even, so the sum of all even divisors of 6 is 8.
//You are given 2 numbers: A and B.For each number in the 
//interval A, B sum the sum of their even divisors.

class SumOfEvenDivisors
{
    static void Main()
    {

        Console.WriteLine("a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("b:");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = a; i <= b; i++) //от едното до др число
        {
            for (int j = 1; j <= i; j++)  //делим от 1 до настоящ число
                                          //т.е. намираме divisors
            {
                if (i % j == 0 && j % 2 == 0) //и да е четен divisors
                {
                    sum += j;
                }
            }
        }
        Console.WriteLine(sum);

    }
}

