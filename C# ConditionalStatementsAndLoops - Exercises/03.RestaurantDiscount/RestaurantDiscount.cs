using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = double.Parse(Console.ReadLine());
            var packageType = Console.ReadLine();
            var price = 0.0;
            if (people <= 50)
            {
                price += 2500;
                if (packageType == "Normal")
                {
                    price += 500;
                    price -= price * 0.05;
                }
                else if (packageType == "Gold")
                {
                    price += 750;
                    price -= price * 0.10;
                }
                else if (packageType == "Platinum")
                {
                    price += 1000;
                    price -= price * 0.15;
                }
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine("The price per person is {0:f2}$", price / people);
            }
            else if (people > 50 && people <= 100)
            {
                price += 5000;
                if (packageType == "Normal")
                {
                    price += 500;
                    price -= price * 0.05;
                }
                else if (packageType == "Gold")
                {
                    price += 750;
                    price -= price * 0.10;
                }
                else if (packageType == "Platinum")
                {
                    price += 1000;
                    price -= price * 0.15;
                }
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine("The price per person is {0:f2}$", price / people);
            }
            else if (people > 100 && people <= 120)
            {
                price += 7500;
                if (packageType == "Normal")
                {
                    price += 500;
                    price -= price * 0.05;
                }
                else if (packageType == "Gold")
                {
                    price += 750;
                    price -= price * 0.10;
                }
                else if (packageType == "Platinum")
                {
                    price += 1000;
                    price -= price * 0.15;
                }
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine("The price per person is {0:f2}$", price / people);
            }
            else if (people > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
