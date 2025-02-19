using System;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Indtast oplysninger om bilen
            Console.WriteLine("Bilmærke?");
            string brand = Console.ReadLine();
            Console.WriteLine("Bilmodel?");
            string model = Console.ReadLine();
            Console.WriteLine("Årgang?");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gearkasse? (A eller M)");
            char transM = Console.ReadLine()[0];
            
            Console.WriteLine("Brændstoftype? (Benzin eller Diesel)");
            string fuelType = Console.ReadLine().ToLower();
            
            Console.WriteLine("Km pr. liter?");
            double kmPerLiter = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Nuværende kilometerstand?");
            int currentMileage = Convert.ToInt32(Console.ReadLine());

            // Spørg brugeren om køreturens distance
            Console.WriteLine("Hvor mange kilometer vil du køre?");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Sæt brændstofprisen
            double fuelPrice = (fuelType == "benzin") ? 13.49 : 12.29;

            // Beregn brændstofforbruget og køreturens pris
            double fuelNeeded = distance / kmPerLiter;
            double tripCost = fuelNeeded * fuelPrice;
            
            // Opdater kilometerstand
            currentMileage += (int)Math.Round(distance);

            // Udskriv brændstofomkostninger med string.Format()
            string fuelCostMessage = string.Format("Brændstofudgifterne for {0} km er {1:F2} DKK.", distance, tripCost);
            Console.WriteLine(fuelCostMessage);

            // Udskriv en tabel med bilens oplysninger ved hjælp af PadRight() og PadLeft()
            Console.WriteLine("\nBilmærke | Model     | Kilometertal");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(brand.PadRight(10) + "| " + model.PadRight(10) + "| " + currentMileage.ToString("N0").PadLeft(10) + " km");
            
            Console.ReadLine(); // Vent på input før programmet afsluttes 
        }
    }
}
