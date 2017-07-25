using System;
using System.Collections.Generic;

namespace TravelCompany
{
    public class Program
    {
        public static void Main()
        {
            var citiesData = new Dictionary<string, Dictionary<string, int>>();
            var transportData = Console.ReadLine();
            while (transportData != "ready")
            {
                var currentCityData = transportData.Split(new[] { ':', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                var city = currentCityData[0];
                var vehicleAndCapacity = currentCityData;

                if (!citiesData.ContainsKey(city))
                {
                    citiesData[city] = new Dictionary<string, int>();
                }

                for (int index = 1; index < vehicleAndCapacity.Length; index += 2)
                {
                    var transportType = vehicleAndCapacity[index];
                    var seats = int.Parse(vehicleAndCapacity[index + 1]);

                    if (!citiesData[city].ContainsKey(transportType))
                    {
                        citiesData[city][transportType] = 0;
                    }
                    citiesData[city][transportType] = seats;
                }

                transportData = Console.ReadLine();
            }

            transportData = Console.ReadLine();

            while (transportData != "travel time!")
            {
                var currentCityAndTourists = transportData.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var city = currentCityAndTourists[0];
                var tourists = Convert.ToInt32(currentCityAndTourists[1]);

                var transportCapacities = 0;
                foreach (var places in citiesData[city])
                {
                    transportCapacities += places.Value;
                }

                if (tourists <= transportCapacities)
                {
                    Console.WriteLine($"{city} -> all {tourists} accommodated");
                }
                else
                {
                    Console.WriteLine($"{city} -> all except {tourists - transportCapacities} accommodated");
                }
                transportData = Console.ReadLine();
            }
        }
    }
}
