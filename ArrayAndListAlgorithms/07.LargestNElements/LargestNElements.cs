using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNElements
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int outputNumbers = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            var output = numbers.Take(outputNumbers);

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
