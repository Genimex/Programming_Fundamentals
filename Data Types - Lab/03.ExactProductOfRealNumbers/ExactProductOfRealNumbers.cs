using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Product_RN
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            decimal safeNumber = decimal.Parse(Console.ReadLine());
            for (int i = 1; i < row; i++)
            {
                safeNumber *= decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine(safeNumber);
        }
    }
}
