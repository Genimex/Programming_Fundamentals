using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integer = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> index = new List<int>();

            for (int i = 0; i < integer.Length; i++)
            {
                if (integer[i] == i)
                {
                    index.Add(integer[i]);
                }
            }

            Console.WriteLine(string.Join(" ", index));
        }
    }
}
