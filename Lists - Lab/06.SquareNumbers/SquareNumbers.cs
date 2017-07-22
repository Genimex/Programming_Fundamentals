using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squareNumbers = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)(Math.Sqrt(numbers[i])))
                {
                    squareNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
