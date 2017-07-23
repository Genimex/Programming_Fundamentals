using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magic)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magic}");

                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1} ", counter, magic);
        }
    }
}