using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to display its multiplication table: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
