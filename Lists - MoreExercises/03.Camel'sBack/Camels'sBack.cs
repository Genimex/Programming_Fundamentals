using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_sBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> N = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int M = int.Parse(Console.ReadLine());
            int counter = 0;

            while (N.Count > M)
            {
                N.RemoveAt(N.Count - 1);
                N.RemoveAt(0);
                counter++;
            }

            if (counter == 0)
            {
                Console.Write("already stable: ");
                Console.WriteLine(string.Join(" ", N));
            }
            else
            {
                Console.WriteLine("{0} rounds",counter);
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", N));
            }
        }
    }
}
