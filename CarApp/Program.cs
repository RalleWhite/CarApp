using System;
using System.Security.Cryptography.X509Certificates;

namespace CarApp
{
    internal class Program
    {
        // Variabler som ikke er en del af bil class
        static double tripCost, distance;

        // Klasse til at gemme bilens oplysninger
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public char TransM { get; set; }
            public string FuelType { get; set; }
            public double KmPerLiter { get; set; }
            public int CurrentMileage { get; set; }

            public Car(string brand, string model, int year, char transM, string fuelType, double kmPerLiter, int currentMileage)
            {
                Brand = brand;
                Model = model;
                Year = year;
                TransM = transM;
                FuelType = fuelType;
                KmPerLiter = kmPerLiter;
                CurrentMileage = currentMileage;
            }
        }
        static List<Car> cars = new List<Car>();

        static void Main(string[] args)
        {
            StartMenu();
        }
        static void StartMenu()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("\nVelkommen til CarApp\nDu har nu følgende muligheder");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1. Indtast Bil     |   2. Kør en tur  |   3. Beregn tur pris");
            Console.WriteLine("4. KM Palindrom    |   5. Bil Info    |   6. Bil Info (TEAM)\n\n");

            Console.WriteLine("Indtast hvilken funktion du vil køre");
            int taskNum = Convert.ToInt32(Console.ReadLine());

            switch (taskNum)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu har valgt program 1");
                    Thread.Sleep(3000);
                    PInput();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu har valgt program 2");
                    Thread.Sleep(3000);
                    PDrive();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu har valgt program 3");
                    Thread.Sleep(3000);
                    PTrip();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu har valgt program 4");
                    Thread.Sleep(3000);
                    PPalin();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu har valgt program 5");
                    Thread.Sleep(3000);
                    PInfo();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDu har valgt program 6");
                    Thread.Sleep(3000);
                    PInfoTeam();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUgyldigt input");
                    Thread.Sleep(3000);
                    StartMenu();
                    break;
            }
        }

        static void PInput()
        {
            Console.ResetColor();
            Console.Clear();
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

            Car newCar = new Car(brand, model, year, transM, fuelType, kmPerLiter, currentMileage);
            cars.Add(newCar);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBilen er gemt!");
            Thread.Sleep(5000);
            StartMenu();
        }

        static void PDrive()
        {
            Console.WriteLine("Denne funktion skal opdateres før den virker med biler fra liste");
            /*
            Console.ResetColor();
            Console.Clear();
            // Spørg brugeren om køreturens distance
            Console.WriteLine("Hvor mange kilometer vil du køre?");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Sæt brændstofprisen
            double fuelPrice = (fuelType == "benzin") ? 13.49 : 12.29;

            // Beregn brændstofforbruget og køreturens pris
            double fuelNeeded = distance / kmPerLiter;
            double tripCost = fuelNeeded * fuelPrice;

            // Opdater kilometerstand
            int currentMileage += (int)Math.Round(distance);*/
        }
        static void PTrip()
        {
            Console.ResetColor();
            Console.Clear();
            // Udskriv brændstofomkostninger med string.Format()
            string fuelCostMessage = string.Format("Brændstofudgifterne for {0} km er {1:F2} DKK.", distance, tripCost);
            Console.WriteLine(fuelCostMessage);
        }

        static bool IsPalindrome(int n)
        {
            int reverse = 0;

            int temp = Math.Abs(n);
            while (temp != 0)
            {
                reverse = (reverse * 10) + (temp % 10);
                temp = temp / 10;
            }
            return (reverse == Math.Abs(n));
        }
        static void PPalin()
        {
            Console.WriteLine("Denne funktion skal opdateres før den virker med biler fra liste");
            /*
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Nuværende kilometerstand er "+currentMileage+"\n");
            if (IsPalindrome(currentMileage) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kilomterstanden er et palindrom");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kilomterstanden er IKKE et palindrom");
            }

            Thread.Sleep(5000);
            StartMenu();*/
        }
        static void PInfo()
        {
            Console.ResetColor();
            Console.Clear();
            // Udskriv en tabel med bilens oplysninger ved hjælp af PadRight() og PadLeft()
            if (cars.Count == 0)
            {
                Console.WriteLine("Ingen biler er blevet gemt endnu.");
            }
            else
            {
                Console.WriteLine("\nBilmærke | Model     | Årgang | Gear  | Brændstof | Km/L  | Kilometerstand");
                Console.WriteLine("----------------------------------------------------------------------------------");

                foreach (var car in cars)
                {
                    Console.WriteLine(car.Brand.PadRight(10) + "| " +
                                      car.Model.PadRight(10) + "| " +
                                      car.Year.ToString().PadRight(7) + "| " +
                                      car.TransM.ToString().PadRight(5) + "| " +
                                      car.FuelType.PadRight(10) + "| " +
                                      car.KmPerLiter.ToString("F2").PadRight(6) + "| " +
                                      car.CurrentMileage.ToString().PadLeft(10) + " km");
                }
            }

            Console.ReadLine(); // Vent på input før programmet afsluttes
            StartMenu();
        }
        static void PInfoTeam()
        {
            // ?
        }
    }
}
