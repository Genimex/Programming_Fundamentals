using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new [] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            SortedDictionary<string,long> dict = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                long phone = 0;
                string name = String.Empty;
                if (long.TryParse(input[0], out phone))
                {
                    name = input[2];
                }
                else
                {
                    name = input[0];
                    phone = long.Parse(input[2]);
                }
                if (!dict.ContainsKey(name))
                {
                    dict[name] = 0;
                }
                dict[name] = phone;

                input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (KeyValuePair<string,long> data in dict)
            {
                Console.WriteLine($"{data.Key} -> {data.Value}");
            }
        }
    }
}
