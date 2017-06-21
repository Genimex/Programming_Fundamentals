using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfDoubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double multiplayer = double.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                arrayOfDoubles[i] *= multiplayer;
            }
            var multipliedArray = string.Join(" ", arrayOfDoubles);
            Console.WriteLine("{0}" + " ",multipliedArray);
        }
    }
}
