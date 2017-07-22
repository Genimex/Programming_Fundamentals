using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string inputString = Console.ReadLine();

            while (inputString != "end")
            {
                int index = ((int)(inputString[0]) - 48);
                int element = int.Parse(inputString);
                numbers.Insert(index, element);

                inputString = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
