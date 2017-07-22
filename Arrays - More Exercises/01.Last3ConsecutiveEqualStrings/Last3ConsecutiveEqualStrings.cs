using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();


            for (int i = inputString.Length - 1; i >= 2; i--)
            {
                if (inputString[i] == inputString[i - 1] && inputString[i] == inputString[i - 2])
                {
                    Console.WriteLine("{0} {0} {0}", inputString[i]);
                    return;
                }
            }
        }
    }
}
