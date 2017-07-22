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
            List<int> inputIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < inputIntegers.Count; i++)
            {
                if (inputIntegers[i] < 0)
                {
                    inputIntegers.RemoveAt(i);
                    i--;
                }
            }

            inputIntegers.Reverse();

            if (inputIntegers.Count > 0)
            {
                Console.WriteLine(String.Join(" ",inputIntegers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
