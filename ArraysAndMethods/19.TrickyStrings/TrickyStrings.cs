using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                string currentString = Console.ReadLine();
                result += currentString + delimiter;

            }
            int remove = delimiter.Length;
            Console.WriteLine(result.Remove(result.Length - remove, remove));
        }
    }
}
