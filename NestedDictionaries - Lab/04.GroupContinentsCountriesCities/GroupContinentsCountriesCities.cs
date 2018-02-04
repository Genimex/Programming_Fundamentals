using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinentsCountriesCities
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> continentData =
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string[] insertData = Console.ReadLine().Split(' ').ToArray();
                string continent = insertData[0];
                string country = insertData[1];
                string city = insertData[2];

                if (!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }
                if (!continentData[continent].ContainsKey(country))
                {
                    continentData[continent].Add(country, new SortedSet<string>());
                }
                continentData[continent][country].Add(city);
            }
            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> data in continentData)
            {
                SortedDictionary<string, SortedSet<string>> countriesData = data.Value;
                Console.WriteLine($" {data.Key}:");

                foreach (KeyValuePair<string, SortedSet<string>> countryData in countriesData)
                {
                    SortedSet<string> cities = countryData.Value;
                    Console.WriteLine($"{countryData.Key} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
