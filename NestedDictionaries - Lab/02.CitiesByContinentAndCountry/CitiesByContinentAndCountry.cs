using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,List<string>>> continentData =
                new Dictionary<string, Dictionary<string,List<string>>>();

            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string[] insertData = Console.ReadLine().Split(' ').ToArray();
                string continent = insertData[0];
                string country = insertData[1];
                string city = insertData[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent,new Dictionary<string, List<string>>());
                }
                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent].Add(country,new List<string>());
                }
                continentData[continent][country].Add(city);
            }
            foreach (KeyValuePair<string,Dictionary<string,List<string>>> data in continentData)
            {
                Dictionary<string,List<string>> countriesData = data.Value;
                Console.WriteLine($" {data.Key}:");

                foreach (KeyValuePair<string,List<string>> countryData in countriesData)
                {
                    List<string> cities = countryData.Value;
                    Console.WriteLine($"{countryData.Key} -> {string.Join(", ",cities)}");
                }
            }
        }
    }
}
