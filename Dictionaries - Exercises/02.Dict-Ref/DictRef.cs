using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict___Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Dictionary<string ,int> dictDef = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                string firstElement = input[0];
                string secondElement = input[2];
                int value = 0;

                if (int.TryParse(secondElement, out value))
                {
                    dictDef[firstElement] = value;
                }
                else
                {
                    if (dictDef.ContainsKey(secondElement))
                    {
                        int secondEntryValue = dictDef[secondElement];
                        dictDef[firstElement] = secondEntryValue;
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            foreach (var kvp in dictDef)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
