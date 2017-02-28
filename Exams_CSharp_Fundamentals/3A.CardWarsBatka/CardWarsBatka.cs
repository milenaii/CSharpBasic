using System;

class CardWarsBatka
{
    static void Main()
    {
        int gamesN = int.Parse(Console.ReadLine());

        bool theXcard1player = false;
        bool theXcard2player = false;

        int player1score = 0;
        int player2score = 0;

        for (int i = 0; i < gamesN; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                string cardsplayer1 = Console.ReadLine();

                switch (cardsplayer1)
                {
                    case "2":
                        player1score += 10;
                        break;
                    case "3":
                        player1score += 9;
                        break;
                    case "4":
                        player1score += 8;
                        break;
                    case "5":
                        player1score += 7;
                        break;
                    case "6":
                        player1score += 6;
                        break;
                    case "7":
                        player1score += 5;
                        break;
                    case "8":
                        player1score += 4;
                        break;
                    case "9":
                        player1score += 3;
                        break;
                    case "10":
                        player1score += 2;
                        break;
                    case "A":
                        player1score += 1;
                        break;
                    case "J":
                        player1score += 11;
                        break;
                    case "Q":
                        player1score += 12;
                        break;
                    case "K":
                        player1score += 13;
                        break;
                    case "Z":
                        player1score *= 2;
                        break;
                    case "Y":
                        player1score -= 200;
                        break;
                    case "X":
                        theXcard1player = true;
                        break;

                    default:
                        break;
                }
            }
            for (int j = 1; j < 4; j++)
            {
                string cardsplayer2 = Console.ReadLine();

                switch (cardsplayer2)
                {
                    case "2":
                        player2score += 10;
                        break;
                    case "3":
                        player2score += 9;
                        break;
                    case "4":
                        player2score += 8;
                        break;
                    case "5":
                        player2score += 7;
                        break;
                    case "6":
                        player2score += 6;
                        break;
                    case "7":
                        player2score += 5;
                        break;
                    case "8":
                        player2score += 4;
                        break;
                    case "9":
                        player2score += 3;
                        break;
                    case "10":
                        player2score += 2;
                        break;
                    case "A":
                        player2score += 1;
                        break;
                    case "J":
                        player2score += 11;
                        break;
                    case "Q":
                        player2score += 12;
                        break;
                    case "K":
                        player2score += 13;
                        break;
                    case "Z":
                        player2score *= 2;
                        break;
                    case "Y":
                        player2score -= 200;
                        break;
                    case "X":
                        theXcard2player = true;
                        break;

                    default:
                        break;
                }
            }
        }
            //Print Result
            if ((theXcard1player && theXcard2player))
            {
                player1score += 50;
                player2score += 50;
            }
            else if (theXcard2player)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                goto final;
            }
            else if (theXcard1player)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                goto final;
            }


            if (player1score > player2score)
            {
                Console.WriteLine("First player wins! \nScore: {0} \nGames won: {1} ", player1score, gamesN);
            }
            else if (player1score < player2score)
            {
                Console.WriteLine("Second player wins! \nScore: {0} \nGames won: {1} ", player2score, gamesN);
            }
            else
            {
                Console.WriteLine("It's a tie! \nScore: {0}", player1score + player2score);
            }

            final:
            Console.WriteLine();
        }

    }



