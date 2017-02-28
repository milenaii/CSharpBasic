using System;

class DrunkenNumbers
{
    static void Main()
    {

        Console.WriteLine("Enter number of rounds: ");
        int rounds = int.Parse(Console.ReadLine());

        //Mitko beers left digit sum
        int leftDigitsSum = 0;

        //Vladko beers right digit sum
        int rightDigitsSum = 0;

        // Read the numbers
        for (int i = 0; i < rounds; i++)
        {
            int currentDrNum = int.Parse(Console.ReadLine());

            //Turn negative numbers to positive
            if (currentDrNum < 0)
            {
                currentDrNum *= -1;
            }

            //Calculate the total number of digits
            int numberOfDigits = 0;
            int num = currentDrNum;
            while (num != 0)
            {
                num = num / 10;
                numberOfDigits++;
            }

            //Sum if digits at the right side - Vladko beers
            for (int right = 0; right < numberOfDigits/2; right++)
            {
                int currentDigit = currentDrNum % 10;
                currentDrNum = currentDrNum / 10;
                rightDigitsSum += currentDigit;
            }

            if (numberOfDigits % 2 ==1) // odd number
            {
                //We have a middle digit - add it to both sum
                int middleDigit = currentDrNum % 10;
                rightDigitsSum += middleDigit;
                leftDigitsSum += middleDigit;
                currentDrNum = currentDrNum / 10;
            }

            //sum of digits at the left side - Mitko beers
            for (int left = 0; left < numberOfDigits/2; left++)
            {
                int currentDigit = currentDrNum % 10;
                currentDrNum = currentDrNum / 10;
                leftDigitsSum += currentDigit;
            }
        }

        //Print the results
        int difference = rightDigitsSum - leftDigitsSum;
        if (difference > 0)
        {
            Console.WriteLine("V {0}", difference);
        }
        else if (difference < 0)
        {
            Console.WriteLine("M {0}",difference * -1);
        }
        else
        {
            Console.WriteLine("No {0}", rightDigitsSum * 2);
        }
    }
}

