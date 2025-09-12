using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student degree (0-100): ");
            int degree = int.Parse(Console.ReadLine());

            if (degree >= 90)
                Console.WriteLine("Grade: A");
            else if (degree >= 80)
                Console.WriteLine("Grade: B");
            else if (degree >= 70)
                Console.WriteLine("Grade: C");
            else if (degree >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }
}
