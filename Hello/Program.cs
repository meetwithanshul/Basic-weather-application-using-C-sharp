using System;
using System.Collections.Generic;
using System.Threading;

namespace WeatherApp
{
    class Program
    {
        static List<string> favoritePlanets = new List<string>();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to The our Weather App!");
            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check Weather on a Planet");
                Console.WriteLine("2. Check Historical Weather Data");
                Console.WriteLine("3. Save Favorite Planet");
                Console.WriteLine("4. Check Weather Forecast");
                Console.WriteLine("5. Exit");

                int option = 0;
                while (option == 0)
                {
                    int.TryParse(Console.ReadLine(), out option);
                }

                switch (option)
                {
                    case 1:
                        CheckWeatherOnPlanet();
                        break;
                    case 2:
                        CheckHistoricalWeatherData();
                        break;
                    case 3:
                        SaveFavoritePlanet();
                        break;
                    case 4:
                        CheckWeatherForecast();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using The our Weather App!");
                        Thread.Sleep(2000);
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Thread.Sleep(2000);
                        break;
                }

                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }

        static void CheckWeatherOnPlanet()
        {
            Console.WriteLine("Enter the name of the planet:");
            string planetName = Console.ReadLine();

            Console.WriteLine($"The current temperature on {planetName} is 30°C.");
            Console.WriteLine($"The current humidity on {planetName} is 45%.");
        }

        static void CheckHistoricalWeatherData()
        {
            Console.WriteLine("Enter the name of the planet:");
            string planetName = Console.ReadLine();

            Console.WriteLine("Enter the date (MM/DD/YYYY):");
            string dateString = Console.ReadLine();

            Console.WriteLine($"On {dateString}, the temperature on {planetName} was 13°C.");
            Console.WriteLine($"On {dateString}, the humidity on {planetName} was 63%.");
        }

        static void SaveFavoritePlanet()
        {
            Console.WriteLine("Enter the name of the planet:");
            string planetName = Console.ReadLine();

            favoritePlanets.Add(planetName);
            Console.WriteLine($"{planetName} has been added to your favorite planets.");

        }

        static void CheckWeatherForecast()
        {
            Console.WriteLine("Enter the name of the planet:");
            string planetName = Console.ReadLine();

            Console.WriteLine($"The forecast for {planetName} predicts:");
            Console.WriteLine("Temperature: 22°C, 24°C, 26°C, 21°C, 19°C, 20°C, 27°C");
            Console.WriteLine("Humidity: 42%, 65%, 38%, 2%, 6%, 18%, 58%");
        }
    }
}