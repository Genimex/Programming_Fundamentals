using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool increasing = false;

            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] == number[i + 1])
                {
                    increasing = true;
                }
                else
                {
                    increasing = false;
                    break;
                }
            }
            if (increasing)
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
