using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputString = Console.ReadLine()
                .Split(new char[] { ',',';',':','.','!','(',')','"', '\'','\\','/','[',']',' ' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < inputString.Count; i++)
            {
                if (inputString[i].All(char.IsUpper))
                {
                    upperCase.Add(inputString[i]);
                }
                else if (inputString[i].All(char.IsLower))
                {
                    lowerCase.Add(inputString[i]);
                }
                else
                {
                    mixedCase.Add(inputString[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
