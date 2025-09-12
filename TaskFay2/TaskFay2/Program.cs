using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            string[] students = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine(" Student Names  :");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }
        }
    }
}
