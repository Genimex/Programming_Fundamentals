using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                for (int i = 0; i <= n / 2 - 1; i++)
                {
                    var formula = n - (2 * i + 2);
                    Console.WriteLine("{0}{1}{2}{1}",new string(' ',i),new string('x',1),new string(' ',formula));
                }
                Console.WriteLine("{0}{1}{0}",new string(' ',n / 2),new string('x',1));
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    var formula = n - (2 * i + 2);
                    Console.WriteLine("{0}{1}{2}{1}", new string(' ', i), new string('x', 1), new string(' ', formula));
                }
            }
        }
    }
}
