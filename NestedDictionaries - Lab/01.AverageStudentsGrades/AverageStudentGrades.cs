using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentData = new Dictionary<string, List<double>>();

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string studentName = input[0];
                double studentGrade = double.Parse(input[1]);

                if (!studentData.ContainsKey(studentName))
                {
                     studentData.Add(studentName,new List<double>());
                }
                studentData[studentName].Add(studentGrade);
            }
            foreach (KeyValuePair<string, List<double>> data in studentData)
            {
                List<double> grades = data.Value;
                double average = grades.Average();
                Console.WriteLine("{0} -> {1} (avg: {2:F2})"
                    ,data.Key, string.Join(" ",grades.Select(g => string.Format("{0:F2}", g)).ToArray()), average);
            }
        }
    }
}
