using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialNotes = new List<string>(new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" });
            List<double> initialFrequencies = new List<double>(new double[]
                {261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88});

            List<double> inputFrequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> totalNotes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double naturalSum = 0.0;
            double sharpSum = 0.0;

            for (int cnt = 0; cnt < inputFrequencies.Count; cnt++)
            {
                int index = initialFrequencies.IndexOf(inputFrequencies[cnt]);
                string currentNote = initialNotes[index];
                double frequency = initialFrequencies[index];

                totalNotes.Add(currentNote);

                if (IsNatural(currentNote))
                {
                    naturals.Add(currentNote);
                    naturalSum += frequency;
                }
                else
                {
                    sharps.Add(currentNote);
                    sharpSum += frequency;
                }
            }
            Console.WriteLine("Notes: {0}", String.Join(" ", totalNotes));
            Console.WriteLine("Naturals: {0}", String.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", String.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", naturalSum);
            Console.WriteLine("Sharps sum: {0}", sharpSum);
        }
        static bool IsNatural(string currentNote)
        {
            if (currentNote.Length == 1)
            {
                return true;
            }
            return false;
        }
    }
}