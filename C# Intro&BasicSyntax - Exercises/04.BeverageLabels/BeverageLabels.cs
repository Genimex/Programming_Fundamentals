using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());
            var kcal = (volume / 100) * energy;
            var gSugar = (volume / 100) * sugar;
            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{kcal}kcal, {gSugar}g sugars");
        }
    }
}
