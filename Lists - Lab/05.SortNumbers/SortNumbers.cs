﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine().Split(new char [] { ' ' }
                ,StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            inputNumbers.Sort();

            Console.WriteLine(string.Join(" <= ", inputNumbers));
        }
    }
}
