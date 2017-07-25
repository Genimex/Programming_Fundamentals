using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var minsPlus = minutes + 30;
            if (minsPlus > 59)
            {
                hours++;
                minsPlus -= 60;
                if (hours > 23)
                {
                    hours -= 24;
                }
            }
            Console.WriteLine("{0}:{1:D2}",hours,minsPlus);
        }
    }
}
