using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double round = Math.Round(num);
            if (num - round == 0.0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("{0}",Math.Round(num));
            }
        }
    }
}
