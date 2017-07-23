using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var studio = 0.0;
            var doubleRoom = 0.0;
            var suite = 0.0;
            if (month == "May" || month == "October")
            {
                studio += 50;
                doubleRoom += 65;
                suite += 75;
                if (nights > 7)
                {
                    studio -= 50 * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio += 60;
                doubleRoom += 72;
                suite += 82;
                if (nights > 14)
                {
                    doubleRoom -= 0.1 * 72;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio += 68;
                doubleRoom += 77;
                suite += 89;
                if (nights > 14)
                {
                    suite -= 0.15 * 89;
                }
            }
            if (month == "September" || month == "October" && nights > 7)
            {
                Console.WriteLine("Studio: {0:f2} lv.",(nights -1) * studio);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", studio * nights);
            }
            Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nights);
            Console.WriteLine("Suite: {0:f2} lv.", suite * nights);
        }
    }
}
