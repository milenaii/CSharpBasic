using System;

class Garden
{
    static void Main()
    {
        int totalArea = 250;  // square meters

        Console.WriteLine("Enter input - 11 integers: ");

        int tomatoAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberAmount = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());

        int potatoAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());

        int carrotAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beansAmount = int.Parse(Console.ReadLine());

        float tomatoPrice = 0.5f;
        float cucumberPrice = 0.4f;
        float potatoPrice = 0.25f;
        float carrotPrice = 0.6f;
        float cabbagePrice = 0.3f;
        float beansPrice = 0.4f;

        float totalCosts = tomatoAmount * tomatoPrice + 
            + cucumberAmount * cucumberPrice +
            + potatoAmount * potatoPrice + 
            + carrotAmount * carrotPrice +
            + cabbageAmount * cabbagePrice + 
            + beansAmount * beansPrice;
        Console.WriteLine("Total costs: {0:0.00}",totalCosts);

        float beansArea = totalArea - (tomatoArea + cucumberArea +
            +potatoArea + carrotArea + cabbageArea);

        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
            Console.WriteLine();
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Insufficient area");
            Console.WriteLine();
        }


    }
}

