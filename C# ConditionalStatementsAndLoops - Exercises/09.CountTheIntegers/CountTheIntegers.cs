using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_The_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = 0;
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    numCount++;
                }
                catch (Exception)
                {
                    Console.WriteLine(numCount);
                    break;
                }
            }
        }
    }
}
