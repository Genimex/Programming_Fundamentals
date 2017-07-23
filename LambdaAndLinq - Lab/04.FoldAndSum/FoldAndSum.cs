using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = inputIntegers.Length / 4;

            int[] leftSide = inputIntegers.Take(k).Reverse().ToArray();

            int[] rightSide = inputIntegers.Reverse().Take(k).ToArray();

            int[] upperRow = leftSide.Concat(rightSide).ToArray();

            int[] lowerRow = inputIntegers.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < lowerRow.Length; i++)
            {
                Console.Write("{0} ",upperRow[i] + lowerRow[i]);
            }
        }
    }
}
