using System;

class SoftUni_Airline
{
    static void Main()
    {
        int numberOfFlights = int.Parse(Console.ReadLine());

        decimal overallProfit = 0;

        for (int i = 0; i < numberOfFlights; i++)
        {
            int adultPassengers = int.Parse(Console.ReadLine());
            decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
            int youthPassengers = int.Parse(Console.ReadLine());
            decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
            decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
            decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
            int flightDuration = int.Parse(Console.ReadLine());

            decimal income = (adultPassengers * adultTicketPrice) + (youthPassengers * youthTicketPrice);

            decimal expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;

            decimal profit = income - expenses;
            overallProfit += profit;

            if (profit >= 0)
            {
                Console.WriteLine("You are ahead with {0:F3}$.", profit);
            }

            else
            {
                Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", profit);
            }
        }

        Console.WriteLine("Overall profit -> {0:F3}$.", overallProfit);

        decimal averageProfit = overallProfit / numberOfFlights;

        Console.WriteLine("Average profit -> {0:F3}$.", averageProfit);
    }
}

