using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class Program
    {
        static void RepeatString()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write(str);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            RepeatString();
        }

    }
}
