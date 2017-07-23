using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();
            switch(profession)
            {
                case "athlete": Console.WriteLine("Water");
                    break;
                case "businessman":
                case "businesswoman": Console.WriteLine("Coffee");
                    break;
                case "softuni student": Console.WriteLine("Beer");
                    break;
                default:
                    {
                        Console.WriteLine("Tea");
                    }
                    break;
            }
        }
    }
}
