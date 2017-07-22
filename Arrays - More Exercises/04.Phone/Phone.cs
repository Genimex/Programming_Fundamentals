using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();


            string[] commandLine = Console.ReadLine().Split(' ').ToArray();

            while (!commandLine[0].Equals("done"))
            {
                if (commandLine[0].Equals("call"))
                {
                    CallMethod(phones, names, commandLine);
                }
                else if (commandLine[0].Equals("message"))
                {
                    MessageMethod(phones, names, commandLine);
                }

                commandLine = Console.ReadLine().Split(' ').ToArray();
            }
        }
         static void MessageMethod(string[] phones, string[] names, string[] commandLine)
        {
            long sum = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (commandLine[1].Equals(phones[i]))
                {
                    Console.WriteLine($"sending sms to {names[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            sum += x - '0';
                        }
                    }
                }
                else if (commandLine[1].Equals(names[i]))
                {
                    Console.WriteLine($"sending sms to {phones[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            sum += x - '0';
                        }
                    }
                }
            }
            if (sum % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else if (sum % 2 != 0)
            {
                Console.WriteLine("busy");
            }
        }
        static void CallMethod(string[] phones, string[] names, string[] commandLine)
        {
            long duration = 0;
            for (int i = 0; i < names.Length; i++)
            {

                if (commandLine[1].Equals(phones[i]))
                {
                    Console.WriteLine($"calling {names[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            duration += x - '0';
                        }
                    }
                }
                else if (commandLine[1].Equals(names[i]))
                {
                    Console.WriteLine($"calling {phones[i]}...");
                    var sumOfDigits = phones[i].ToCharArray();
                    foreach (var x in sumOfDigits)
                    {
                        if (x >= 48 && x <= 57)
                        {
                            duration += x - '0';
                        }
                    }
                }
            }

            if (duration % 2 == 0)
            {
                TimeSpan t = TimeSpan.FromSeconds(duration);
                string answer = string.Format("call ended. duration: {0:D2}:{1:D2}",
                    t.Minutes,
                    t.Seconds);
                Console.WriteLine(answer);
            }

            else if (duration % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
        }
    }
}
// another task
namespace __04.Phone
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string[] inputName = Console.ReadLine().Split();

            while (inputName[0] != "done")
            {

                if (inputName[0] == "call")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (inputName[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);

                            if (sumOfDiggits % 2 == 1)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = sumOfDiggits / 60;
                                int seconds = sumOfDiggits % 60;
                                string duration = $"{minutes:d2}:{seconds:d2}";
                                Console.WriteLine($"call ended. duration: {duration}");
                            }
                        }
                        if (inputName[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);

                            if (sumOfDiggits % 2 == 1)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = sumOfDiggits / 60;
                                int seconds = sumOfDiggits % 60;
                                string duration = $"{minutes:d2}:{seconds:d2}";
                                Console.WriteLine($"call ended. duration: {duration}");
                            }
                        }
                    }
                }
                if (inputName[0] == "message")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (inputName[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);

                            if (sumOfDiggits % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                        if (inputName[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");

                            string phoneNumber = phoneNumbers[i];
                            int sumOfDiggits = TakeSumOfDiggits(phoneNumber);
                            if (sumOfDiggits % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }
                    }
                }

                inputName = Console.ReadLine().Split();
            }
        }

        private static int TakeSumOfDiggits(string phoneNumber)
        {
            int sumOfDiggits = 0;

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (phoneNumber[i] >= 48 && phoneNumber[i] <= 57)
                {
                    sumOfDiggits += ((int)phoneNumber[i] - 48);
                }
            }
            return sumOfDiggits;
        }
    }
}
