using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int total = 0; int specialNumber = 0; bool special = false;
            for (int number = 1; number <= length; number++)
            {
                specialNumber = number;
                while (number > 0)
                {
                    total += number % 10;
                    number = number / 10;
                }
                special = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{specialNumber} -> {special}");
                total = 0;
                number = specialNumber;
            }
        }
    }
}
