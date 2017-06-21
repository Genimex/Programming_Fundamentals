using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] elements = new int[numberOfElements];
            int sumOfElements = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                elements[i] = currentNumber;
                sumOfElements += elements[i];
            }
            Console.WriteLine(sumOfElements);
        }
    }
}
