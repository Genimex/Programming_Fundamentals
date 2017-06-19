using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrences_Of_Larger_Number_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] elements = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > p)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
