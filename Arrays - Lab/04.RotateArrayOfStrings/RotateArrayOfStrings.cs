using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ');
            string[] rotatedStrings = new string[inputStrings.Length];
            var firstIndex = inputStrings[inputStrings.Length - 1];

            for (int i = 0; i < inputStrings.Length - 1; i++)
            {
                rotatedStrings[i + 1] = inputStrings[i];
            }
            rotatedStrings[0] = firstIndex;
            var rotated = string.Join(" ", rotatedStrings);
            Console.WriteLine(rotated);
        }
    }
}
