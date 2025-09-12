using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number to get its ascii  ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine($"Character for ASCII {code} is '{(char)code}'");
        }
    }
}
