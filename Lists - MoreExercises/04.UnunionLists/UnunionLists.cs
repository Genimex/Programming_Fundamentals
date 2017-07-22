using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                List<int> numbersToCheck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < numbersToCheck.Count; j++)
                {

                    if (numbers.Contains(numbersToCheck[j]))
                    {
                        numbers.RemoveAll(x => x == numbersToCheck[j]);
                    }
                    else
                    {
                        numbers.Add(numbersToCheck[j]);
                    }
                }
            }

            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
