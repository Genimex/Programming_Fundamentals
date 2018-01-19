using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            inputNumbers.Sort();

            inputNumbers.Add(int.MaxValue);

            int counter = 1;

            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                if (inputNumbers[i] == inputNumbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", inputNumbers[i], counter);
                    counter = 1;
                }
            }
        }
    }
}
