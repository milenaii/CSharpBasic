using System;

class SwitchCase    
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

            default:                 // може и без default - ако не се случи case,
                                                 // програмата продължава напред
                Console.WriteLine("Error!");
                break;
            // Ако искаме да махнем break или от единият case
            // да отидем директно в другия case, условието в 
            // 1 го слагаме в 2:

            //case 1:
            //case 2:
            //    Console.WriteLine("Monday");
            //    Console.WriteLine("Tuesday");
            //    break;

            //за двата case изпълняваме един код и след това break
        }
    }
}

