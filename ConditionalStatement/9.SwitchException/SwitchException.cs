using System;

class SwitchException
{
    static void Main()
    {
        Console.WriteLine("Enter number 1 - 7: ");
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;

            default:
                throw new Exception("Invalid number");
                // по този начин знаем къде нещата не се случват правилно и къде 
                // да гледаме!!

        }
    }
}