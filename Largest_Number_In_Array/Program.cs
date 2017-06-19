using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int largestNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentDigit = int.Parse(Console.ReadLine());
                array[i] = currentDigit;
                if (largestNumber < currentDigit)
                {
                    largestNumber = currentDigit;
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}
