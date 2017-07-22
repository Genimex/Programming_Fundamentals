using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split();
            string[] name = Console.ReadLine().Split();
            string inputName = Console.ReadLine();

            while (inputName != "done")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (inputName == name[i])
                    {
                        Console.WriteLine($"{name[i]} -> {phoneNumber[i]}");
                        break;
                    }
                }
                inputName = Console.ReadLine();
            }
        }
    }
}
