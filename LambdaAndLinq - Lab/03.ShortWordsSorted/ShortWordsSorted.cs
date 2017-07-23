using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().ToLower()
                .Split(" .,:;()[]\"'\\/!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            Console.WriteLine($"{String.Join(", ", inputWords)}");
        }
    }
}
