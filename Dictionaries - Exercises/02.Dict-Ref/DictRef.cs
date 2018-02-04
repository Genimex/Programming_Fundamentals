using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary___ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> words = new Dictionary<string, int>();

            List<string> input = Console.ReadLine().Split(' ').Select(w => w.ToLower()).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (!words.ContainsKey(input[i]))
                {
                    words.Add(input[i], 0);
                }
                words[input[i]]++;
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string,int> word in words)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
