using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split(' ');
            bool symmetric = false;
            int n = inputString.Length / 2;
            for (int i = 0; i < n; i++)
            {
                if (inputString[i] == inputString[inputString.Length - 1 - i])
                {
                    symmetric = true;
                }
                else
                {
                    symmetric = false;
                    break;
                }
            }
            if (symmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
