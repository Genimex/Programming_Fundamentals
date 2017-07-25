using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderFooter(n);
            for (int i = 0; i < n-2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderFooter(n);
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i <= (2 * n-2)/2; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
