using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char forbidenChar = char.Parse(Console.ReadLine());

            for (int firstLetter = start; firstLetter <= end; firstLetter++)
            {
                for (int secondLetter = start; secondLetter <= end; secondLetter++)
                {
                    for (int thirdLetter = start; thirdLetter <= end; thirdLetter++)
                    {
                        if (firstLetter == forbidenChar || secondLetter == forbidenChar || thirdLetter == forbidenChar)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}