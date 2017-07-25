using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetiton
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToArray();
            
            Dictionary<char,int> output = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (!output.ContainsKey(letter))
                {
                    output[letter] = 0;
                }
                output[letter]++;
            }
            foreach (var letter in output)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
