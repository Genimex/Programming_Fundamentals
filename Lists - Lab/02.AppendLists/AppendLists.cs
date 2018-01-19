using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNumbers = Console.ReadLine().Split('|').ToList();

            string results = string.Empty;

            for (int i = inputNumbers.Count - 1; i >= 0; i--)
            {
                string element = inputNumbers[i];
                List<string> numbers = element.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int append = 0; append < numbers.Count; append++)
                {
                    results += numbers[append] + " ";
                }
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
