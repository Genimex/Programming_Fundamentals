using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPersons = double.Parse(Console.ReadLine());
            double courses = numberOfPersons / (4 + 8 + 12);
            Console.WriteLine("{0}",Math.Ceiling(courses));
        }
    }
}
