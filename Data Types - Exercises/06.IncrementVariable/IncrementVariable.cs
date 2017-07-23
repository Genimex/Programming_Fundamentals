using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 256 == 0)
                {
                    count++;
                }
            }
            if (n > 255)
            {
                Console.WriteLine(n - (count * 256));
                Console.WriteLine("Overflowed {0} times", count);
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}
