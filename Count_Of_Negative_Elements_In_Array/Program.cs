using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Of_Negative_Elements_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int negativeElements = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                array[i] = currentNumber;
                if (currentNumber < 0)
                {
                    negativeElements++;
                }
            }
            Console.WriteLine(negativeElements);
        }
    }
}
