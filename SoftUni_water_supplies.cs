using System;
using System.Collections.Generic;
using System.Linq;

class SoftUni_water_supplies
{
    static void Main()
    {
        decimal amountOfWater = decimal.Parse(Console.ReadLine());
        decimal[] bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        decimal bottleCapacity = decimal.Parse(Console.ReadLine());

        decimal litersNeeded = 0;
        int bottlesLeftToFill = 0;
        List<int> indexes = new List<int>();

        if (amountOfWater % 2 == 0)
        {
            for (int i = 0; i < bottles.Length; i++)
            {
                litersNeeded += bottleCapacity - bottles[i];

                if (litersNeeded > amountOfWater)
                {
                    bottlesLeftToFill++;
                    indexes.Add(i);
                }
            }

            if (litersNeeded > amountOfWater)
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", bottlesLeftToFill);
                Console.WriteLine("With indexes: {0}", String.Join(", ", indexes));

                if (litersNeeded % 1 == 0)
                {
                    Console.WriteLine("We need {0} more liters!", litersNeeded - amountOfWater);
                }

                else
                {
                    Console.WriteLine("We need {0:F3} more liters!", litersNeeded - amountOfWater);
                }
            }

            else
            {
                Console.WriteLine("Enough water!");

                if (litersNeeded % 1 == 0)
                {
                    Console.WriteLine("Water left: {0}l.", amountOfWater - litersNeeded);
                }
                else
                {
                    Console.WriteLine("Water left: {0:F3}l.", amountOfWater - litersNeeded);
                }
            }
        }

        else
        {
            for (int i = bottles.Length - 1; i >= 0; i--)
            {
                litersNeeded += bottleCapacity - bottles[i];

                if (litersNeeded > amountOfWater)
                {
                    bottlesLeftToFill++;
                    indexes.Add(i);
                }
            }

            if (litersNeeded > amountOfWater)
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", bottlesLeftToFill);
                Console.WriteLine("With indexes: {0}", String.Join(", ", indexes));

                if (litersNeeded % 1 == 0)
                {
                    Console.WriteLine("We need {0} more liters!", litersNeeded - amountOfWater);
                }

                else
                {
                    Console.WriteLine("We need {0:F3} more liters!", litersNeeded - amountOfWater);
                }
            }

            else
            {
                Console.WriteLine("Enough water!");

                if (litersNeeded % 1 == 0)
                {
                    Console.WriteLine("Water left: {0}l.", amountOfWater - litersNeeded);
                }
                else
                {
                    Console.WriteLine("Water left: {0:F3}l.", amountOfWater - litersNeeded);
                }
            }
        }
    }
}

