using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int> letters = new Dictionary<char, int>();

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!letters.ContainsKey(input[i]))
                {
                    letters.Add(input[i], 0);
                }
                letters[input[i]]++;
            }
            foreach (KeyValuePair<char,int> letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
