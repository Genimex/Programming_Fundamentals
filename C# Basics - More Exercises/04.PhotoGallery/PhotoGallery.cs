using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = int.Parse(Console.ReadLine());
            int widthRes = int.Parse(Console.ReadLine());
            int heightRes = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNumber);
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D2} {hour:D2}:{minutes:D2}");
            if (size <= 1024)
            {
                Console.WriteLine("Size: {0}B", size);
            }
            else if (size > 1024 && size < 1000000)
            {
                Console.WriteLine("Size: {0}KB", Math.Round((size / 1000), 1));
            }
            else if (size >= 1000000)
            {
                Console.WriteLine("Size: {0}MB", Math.Round((size / 1000000), 1));
            }
            if (widthRes > heightRes)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", widthRes, heightRes);
            }
            else if (widthRes < heightRes)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", widthRes, heightRes);
            }
            else if (widthRes == heightRes)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", widthRes, heightRes);
            }
        }
    }
}
