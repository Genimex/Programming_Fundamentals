using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = Console.ReadLine().ToCharArray();
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    chars[i] = (char)((int)chars[i] - integers[i]);
                }
                else
                {
                    chars[i] = (char)((int)chars[i] + integers[i]);
                }
            }
            Console.WriteLine(string.Join("", chars));
        }
    }
}
