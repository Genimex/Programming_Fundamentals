using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var calories = 0;
            for (int i = 1; i <= number; i++)
            {
                var currentIngredient = Console.ReadLine().ToLower();
                if (currentIngredient == "cheese")
                {
                    calories += 500;
                }
                else if (currentIngredient == "tomato sauce")
                {
                    calories += 150;
                }
                else if (currentIngredient == "salami")
                {
                    calories += 600;
                }
                else if (currentIngredient == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine("Total calories: {0}",calories);
        }
    }
}
