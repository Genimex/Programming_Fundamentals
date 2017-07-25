using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            List<string> results = new List<string>();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!counts.ContainsKey(words[i]))
                {
                    counts.Add(words[i],0);
                }
                counts[words[i]]++;
            }
            foreach (KeyValuePair<string,int> word in counts)
            {
                if (word.Value % 2 == 1)
                {
                    results.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
