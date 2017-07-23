using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(' ').ToList();
            List<string> output = new List<string>();
            string filename = Console.ReadLine();
            bool isBannedWord = false;

            while (filename != "end")
            {
                for (int i = 0; i < bannedWords.Count; i++)
                {
                    if (filename.Contains(bannedWords[i]))
                    {
                        isBannedWord = true;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (!isBannedWord)
                {
                    output.Add(filename);
                }

                isBannedWord = false;
                filename = Console.ReadLine();
            }

            output.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, output));
        }
    }
}
