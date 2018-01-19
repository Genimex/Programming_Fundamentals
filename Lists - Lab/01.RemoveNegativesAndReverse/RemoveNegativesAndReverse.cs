using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> saveNums = new List<int>();

            var counter = saveNums.Count;

            foreach (var number in nums)
            {
                if (number > 0)
                {
                    saveNums.Add(number);
                }
            }
            if (saveNums.Count <= 0)
            {
                Console.WriteLine("empty");
                return;
            }
            saveNums.Reverse();
            Console.WriteLine(String.Join(" ",saveNums));
        }
    }
}
