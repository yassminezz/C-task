using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine($"ASCII code of '{ch}' : {(int)ch}");
        }
 
        }

    }

