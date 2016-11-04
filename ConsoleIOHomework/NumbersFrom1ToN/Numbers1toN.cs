﻿using System;
//Write a program that reads an integer number N from the console and prints all the numbers in the interval[1, n], each on a single line.
//Input
//On the only line you will receive the number N
//Output
//You should print the numbers from 1 to N, each on a separate line
//Constraints
//1 <= N< 1000
class Numbers1toN
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number: 1 <= N <= 1000 ");
        int N = int.Parse(Console.ReadLine());

        if (!(1 < N) ^ !(N <= 1000))
        {
            Console.WriteLine("Not valid number!");
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}

