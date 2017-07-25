using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            Console.Write($"Length: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write($"Width: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write($"Height: ");
            double V = (lenght * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}
