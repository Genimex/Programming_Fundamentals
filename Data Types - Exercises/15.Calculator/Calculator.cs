using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var action = Console.ReadLine();
            var secondNUmber = int.Parse(Console.ReadLine());
            var result = 0;

            switch (action)
            {
                case "-":
                    result = firstNumber - secondNUmber;
                    break;
                case "+":
                    result = firstNumber + secondNUmber;
                    break;
                case "/":
                    result = firstNumber / secondNUmber;
                    break;
                case "*":
                    result = firstNumber * secondNUmber;
                    break;
            }
            Console.WriteLine($"{firstNumber} {action} {secondNUmber} = {result}");
        }
    }
}
