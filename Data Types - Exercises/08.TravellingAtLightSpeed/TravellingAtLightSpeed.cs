using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal timeT = (lightYears * 9450000000000M) / 300000M;

            decimal timeInWeeks = timeT / (60M * 60M * 24M * 7M);
            decimal timeInDays = (timeT / (60M * 60M * 24M)) % 7;
            decimal timeInHours = (timeT / (60M * 60M)) % 24;
            decimal timeInMinutes = (timeT / (60M)) % 60;
            decimal timeInSeconds = timeT % 60;

            Console.WriteLine("{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds",
                Math.Floor(timeInWeeks),
                Math.Floor(timeInDays),
                Math.Floor(timeInHours),
                Math.Floor(timeInMinutes),
                Math.Floor(timeInSeconds));
        }
    }
}