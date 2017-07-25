using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theathre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayType = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            if (age >= 0 && age <= 18)
            {
                if (dayType == "weekday")
                {
                    price = 12;
                }
                else if (dayType == "weekend")
                {
                    price = 15;
                }
                else if (dayType == "holiday")
                {
                    price = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (dayType == "weekday")
                {
                    price = 18;
                }
                else if (dayType == "weekend")
                {
                    price = 20;
                }
                else if (dayType == "holiday")
                {
                    price = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (dayType == "weekday")
                {
                    price = 12;
                }
                else if (dayType == "weekend")
                {
                    price = 15;
                }
                else if (dayType == "holiday")
                {
                    price = 10;
                }
            }
            if (price != 0)
            {
                Console.WriteLine("{0}$", price);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
