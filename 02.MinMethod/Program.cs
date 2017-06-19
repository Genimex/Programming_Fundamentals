using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var minNumber = GetMinNumber(number1, number2, number3);
            Console.WriteLine(minNumber);
        }

        static int GetMinNumber(params int[] numbers)
        {
            int minNumber = int.MaxValue;
            foreach (var num in numbers)
            {
                minNumber = num < minNumber ? num : minNumber;
            }
            return minNumber;
        }
    }
}
