using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int seasonCount = 0;
            int daysSurvived = 0;

            while (plants.Max() >= 0)
            {
                for (int days = 0; days < plants.Length; days++)
                {

                    for (int eachPlant = 0; eachPlant < plants.Length; eachPlant++)
                    {
                        if (days != eachPlant && plants[eachPlant] > 0)
                        {
                            plants[eachPlant]--;
                        }
                    }
                    daysSurvived++;

                    if (plants.Max() == 0)
                    {
                        break;
                    }
                }

                if (plants.Max() == 0)
                {
                    break;
                }

                for (int seasonBreak = 0; seasonBreak < plants.Length; seasonBreak++)
                {

                    if (plants[seasonBreak] > 0)
                    {
                        plants[seasonBreak]++;
                    }
                }

                seasonCount++;
            }
            if (seasonCount == 1)
            {
                Console.WriteLine($"survived {daysSurvived} days ({seasonCount} season)");
            }
            else
            {
                Console.WriteLine($"survived {daysSurvived} days ({seasonCount} seasons)");
            }
        }
    }
}
