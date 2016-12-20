using System;
//Write a program that reads a card sign(as a string) from the console
//and generates and prints all possible cards from a standard deck of 52 
//cards up to the card with the given sign(without the jokers). 
//The cards should be printed using the classical notation 
//(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
class PrintADeck
{
    static void Main()
    {
        //int

        //Console.WriteLine("Enter card: ");
        //int card = int.Parse(Console.ReadLine());

        //for (int i = 2; i <= card; i++) 
        //{
        //    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
        //}


        // prints all cards
        //string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //string[] colours = new string[] { "of spades", "of clubs", "of hearts", "of diamonds" };

        //foreach (string s in cards)
        //{
        //    foreach (string m in colours)
        //    {
        //        Console.Write("{0} {1}, ", s, m);
        //    }
        //}


        string n = Console.ReadLine();
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] colours = new string[] { "of spades", "of clubs", "of hearts", "of diamonds" };

        for (int i = 1; i <= 4; i++)
        {
            if (n == colours[i])
            {
                Console.WriteLine("ok");
                break;
            }
            

        }
        {

        }
        

        
    }
}

