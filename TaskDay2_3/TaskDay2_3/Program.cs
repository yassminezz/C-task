using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay2_3
{
    internal class Program
    {
        class Time
        {
            public int Hours;
            public int Minutes;
            public int Seconds;

            public void Print()
            {
                Console.WriteLine($"{Hours:D2}H:{Minutes:D2}M:{Seconds:D2}S");
            }
        }
        static void Main(string[] args)
        {
            Time t = new Time();
            t.Hours = 22;
            t.Minutes = 33;
            t.Seconds = 11;

            t.Print();
        }
    }
}
