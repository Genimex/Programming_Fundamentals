using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double,int> realNumbers = new SortedDictionary<double, int>();

            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (!realNumbers.ContainsKey(input[i]))
                {
                    realNumbers.Add(input[i], 0);
                }
                 realNumbers[input[i]]++;
            }
            foreach (KeyValuePair<double,int> number in realNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
