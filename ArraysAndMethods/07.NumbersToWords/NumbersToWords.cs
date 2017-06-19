using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50NumbersToWords2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long number = 0;
            string toPrint = "";
            long realNumber = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                realNumber = number;

                if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (number > -99 && number < 100)
                {
                    Console.Write("");
                }
                else
                {

                    number = Math.Abs(number);

                    string hundredsToPrint = "";
                    string tensToPrint = "";
                    string onesToPrint = "";

                    string tensAndOnesToPrint = "";




                    long hundreds = number / 100;
                    long tens = (number % 100) / 10;
                    long ones = number % 10;

                    long tensAndOnes = number % 100;


                    switch (hundreds)
                    {
                        case 1: hundredsToPrint = "one-hundred"; break;
                        case 2: hundredsToPrint = "two-hundred"; break;
                        case 3: hundredsToPrint = "three-hundred"; break;
                        case 4: hundredsToPrint = "four-hundred"; break;
                        case 5: hundredsToPrint = "five-hundred"; break;
                        case 6: hundredsToPrint = "six-hundred"; break;
                        case 7: hundredsToPrint = "seven-hundred"; break;
                        case 8: hundredsToPrint = "eight-hundred"; break;
                        case 9: hundredsToPrint = "nine-hundred"; break;
                        default:
                            break;
                    }

                    switch (tens)
                    {
                        // case 1: tensToPrint = "one-hundred"; break;
                        case 2: tensToPrint = "twenty"; break;
                        case 3: tensToPrint = "thirty"; break;
                        case 4: tensToPrint = "fourty"; break;
                        case 5: tensToPrint = "fifty"; break;
                        case 6: tensToPrint = "sixty"; break;
                        case 7: tensToPrint = "seventy"; break;
                        case 8: tensToPrint = "eighty "; break;
                        case 9: tensToPrint = "ninety"; break;

                        default:
                            break;
                    }

                    switch (ones)
                    {
                        case 1: onesToPrint = "one"; break;
                        case 2: onesToPrint = "two"; break;
                        case 3: onesToPrint = "three"; break;
                        case 4: onesToPrint = "four"; break;
                        case 5: onesToPrint = "five"; break;
                        case 6: onesToPrint = "six"; break;
                        case 7: onesToPrint = "seven"; break;
                        case 8: onesToPrint = "eight "; break;
                        case 9: onesToPrint = "nine"; break;
                        case 0: onesToPrint = ""; break;
                        default:
                            break;
                    }

                    if (tensAndOnes < 20)
                    {
                        switch (tensAndOnes)
                        {
                            case 1: tensAndOnesToPrint = "one"; break;
                            case 2: tensAndOnesToPrint = "two"; break;
                            case 3: tensAndOnesToPrint = "three"; break;
                            case 4: tensAndOnesToPrint = "four"; break;
                            case 5: tensAndOnesToPrint = "five"; break;
                            case 6: tensAndOnesToPrint = "six"; break;
                            case 7: tensAndOnesToPrint = "seven"; break;
                            case 8: tensAndOnesToPrint = "eight "; break;
                            case 9: tensAndOnesToPrint = "nine"; break;
                            case 10: tensAndOnesToPrint = "ten"; break;
                            case 11: tensAndOnesToPrint = "eleven"; break;
                            case 12: tensAndOnesToPrint = "twelve"; break;
                            case 13: tensAndOnesToPrint = "thirteen"; break;
                            case 14: tensAndOnesToPrint = "fourteen"; break;
                            case 15: tensAndOnesToPrint = "fifteen"; break;
                            case 16: tensAndOnesToPrint = "sixteen"; break;
                            case 17: tensAndOnesToPrint = "seventeen"; break;
                            case 18: tensAndOnesToPrint = "eighteen "; break;
                            case 19: tensAndOnesToPrint = "nineteen"; break;
                            default:
                                break;
                        }
                        toPrint = $"{hundredsToPrint} and {tensAndOnesToPrint}";


                    }
                    else
                    {

                        toPrint = $"{hundredsToPrint} and {tensToPrint} {onesToPrint}";
                    }

                    switch (number)
                    {
                        case 100: toPrint = "one-hundred"; break;
                        case 200: toPrint = "two-hundred"; break;
                        case 300: toPrint = "three-hundred"; break;
                        case 400: toPrint = "four-hundred"; break;
                        case 500: toPrint = "five-hundred"; break;
                        case 600: toPrint = "six-hundred"; break;
                        case 700: toPrint = "seven-hundred"; break;
                        case 800: toPrint = "eight-hundred"; break;
                        case 900: toPrint = "nine-hundred"; break;
                        default:
                            break;
                    }

                    if (realNumber < 0)
                    {
                        Console.WriteLine($"minus {toPrint}");
                    }
                    else
                    {
                        Console.WriteLine(toPrint);
                    }

                }
            }

        }
    }
}