using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Of_Given_Elements_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentElement = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == currentElement)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
