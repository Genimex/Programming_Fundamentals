using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Name_Method
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            InputName(name);
        }
        static void InputName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
