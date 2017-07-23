using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine($"{String.Join(" ",inputNumbers)}");

        }
    }
}
