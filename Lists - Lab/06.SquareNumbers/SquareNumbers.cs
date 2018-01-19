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
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            inputNumbers.Sort();
            inputNumbers.Reverse();

            List<int> squareNumbers = new List<int>();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (Math.Sqrt(inputNumbers[i]) == (int)Math.Sqrt(inputNumbers[i]))
                {
                    squareNumbers.Add(inputNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ",squareNumbers));
        }
    }
}
