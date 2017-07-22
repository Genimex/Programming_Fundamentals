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
            List<string> tokens = Console.ReadLine().Split('|').ToList();
            string result = string.Empty;

            for (int i = tokens.Count - 1; i >= 0; i--)
            {
                string elements = tokens[i];
                var parts = elements.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int append = 0; append < parts.Count; append++)
                {
                    result += parts[append] + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
