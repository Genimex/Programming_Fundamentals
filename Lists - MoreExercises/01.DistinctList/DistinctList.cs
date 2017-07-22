using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> repeatingElements = inputIntegers.Distinct().ToList();

            Console.WriteLine(string.Join(" ", repeatingElements));
        }
    }
}
