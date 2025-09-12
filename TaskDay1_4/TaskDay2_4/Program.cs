using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum = {a + b}");
            Console.WriteLine($"Subtraction = {a - b}");
            Console.WriteLine($"Multiplication = {a * b}");
        }
    }
}
