using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Terabytes_To_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal terabyte = decimal.Parse(Console.ReadLine());
            decimal sum = 1024m * 1024m * 1024m * 1024m * 8m;
            decimal bits = terabyte * sum;
            Console.WriteLine(Math.Round(bits));
        }
    }
}
