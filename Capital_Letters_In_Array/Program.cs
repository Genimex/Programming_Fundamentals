using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital_Letters_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split(' ');
            int capitalLetterCounter = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                string currentString = inputString[i];

                if (currentString.Length == 1)
                {
                    if (currentString[0] >= 'A' && currentString[0] <= 'Z')
                    {
                        capitalLetterCounter++;
                    }
                }
            }
            Console.WriteLine(capitalLetterCounter);
        }
    }
}
