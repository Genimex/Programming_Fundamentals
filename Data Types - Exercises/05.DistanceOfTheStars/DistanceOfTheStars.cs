using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = 9450000000000m;
            decimal distFromEarth = 4.22m * lightYears;
            decimal centerOfGalaxy = 26000m * lightYears;
            decimal milkyWay = 100000m * lightYears;
            decimal toEdge = 46500000000m * lightYears;

            Console.WriteLine($"{distFromEarth:e2}");
            Console.WriteLine($"{centerOfGalaxy:e2}");
            Console.WriteLine($"{milkyWay:e2}");
            Console.WriteLine($"{toEdge:e2}");
        }
    }
}
