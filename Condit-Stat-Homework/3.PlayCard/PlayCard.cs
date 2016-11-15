﻿using System;
    
//Classical play cards use the following signs to designate the card face:
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.Write a program that enters a 
//    string and prints "yes CONTENT_OF_STRING" if it is a valid card sign
//    or "no CONTENT_OF_STRING" otherwise.

class PlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter play card: ");
        string a = Console.ReadLine();
        if ((0 < a.Length) && (a.Length < 6))
        {
            switch (a)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("yes {0}", a);
                    break;
                default:
                    Console.WriteLine("no {0}", a);
                    break;
            }
        }
        else
        {
            Console.WriteLine("String Length is too big.");
        }
        
    }
}

