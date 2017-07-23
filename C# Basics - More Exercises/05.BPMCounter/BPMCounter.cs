using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());
            double bars = Math.Round(numberOfBeats / 4.0,1);
            int minutes = 0;
            int sec = numberOfBeats * 60 / bpm;
            if (sec >= 60)
            {
                minutes = sec / 60;
                sec -= minutes * 60;
            }
            Console.WriteLine($"{bars} bars - {minutes}m {sec}s");
        }
    }
}
