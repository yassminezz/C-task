using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of tracks: ");
            int tracks = int.Parse(Console.ReadLine());

            Console.Write("Enter number of students per track: ");
            int studentsPerTrack = int.Parse(Console.ReadLine());

            int[,] ages = new int[tracks, studentsPerTrack];

            // Input ages
            for (int t = 0; t < tracks; t++)
            {
                Console.WriteLine($"nTrack {t + 1}:");
                for (int s = 0; s < studentsPerTrack; s++)
                {
                    Console.Write($"Enter age of student {s + 1}: ");
                    ages[t, s] = int.Parse(Console.ReadLine());
                }
            }

            for (int t = 0; t < tracks; t++)
            {
                Console.WriteLine($"\nTrack {t + 1} ages:");
                int sum = 0;
                for (int s = 0; s < studentsPerTrack; s++)
                {
                    Console.WriteLine(ages[t, s]);
                    sum += ages[t, s];
                }
                double avg = (double)sum / studentsPerTrack;
                Console.WriteLine($"Average age for track {t + 1}: {avg:F2}");
            }
        }
    }
}
