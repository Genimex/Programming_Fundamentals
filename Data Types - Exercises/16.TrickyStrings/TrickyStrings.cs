using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var separator = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());

            var stringList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                var words = Console.ReadLine();
                stringList.Add(words);
            }

            Console.WriteLine(string.Join(separator, stringList));
        }
    }
}
