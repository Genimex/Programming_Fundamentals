using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            SortedDictionary<string, long> phoneNumbers = new SortedDictionary<string, long>();

            while (line[0] != "Over")
            {
                long phone = 0;
                string person = String.Empty;

                if (long.TryParse(line[0], out phone))
                {
                    person = line[2];
                }
                else
                {
                    person = line[0];
                    phone = long.Parse(line[2]);
                }

                if (!phoneNumbers.ContainsKey(person))
                {
                    phoneNumbers[person] = 0;
                }
                phoneNumbers[person] = phone;


                line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var kvp in phoneNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
