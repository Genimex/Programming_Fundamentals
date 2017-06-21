using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestElement = int.MaxValue;

            for (int i = 0; i < number.Length; i++)
            {
                var currentNumber = number[i];
                if (currentNumber < smallestElement)
                {
                    smallestElement = currentNumber;
                }
            }
            Console.WriteLine(smallestElement);
        }
    }
}
