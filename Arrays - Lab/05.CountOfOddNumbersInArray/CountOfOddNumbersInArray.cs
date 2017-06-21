using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] % 2 != 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
