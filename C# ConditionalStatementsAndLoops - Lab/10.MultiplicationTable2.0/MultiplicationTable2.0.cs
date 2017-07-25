using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            if (m > 10)
            {
                Console.WriteLine("{0} X {1} = {2}",n,m,n * m);
            }
            for (int i = m; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, n * i);
            }
        }
    }
}
