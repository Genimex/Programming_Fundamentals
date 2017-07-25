using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    public class Program
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(num, power);
            Console.WriteLine(result);
        }
        static double RaiseToPower(double num, double power)
        {
            double result = Math.Pow(num, power);
            return result;
        }
    }
}
