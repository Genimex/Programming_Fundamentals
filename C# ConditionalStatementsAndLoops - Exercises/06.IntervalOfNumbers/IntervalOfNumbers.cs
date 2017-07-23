using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    Console.WriteLine(i);
                }
            }
            if (m < n)
            {
                for (int i = m; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
