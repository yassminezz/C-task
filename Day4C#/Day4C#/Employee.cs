using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Employee
    {
        public string Name { get; set; }
        public List<Cources> Courses { get; set; } 

        public Employee(string name)
        {
            Courses = new List<Cources>();
            Name = name;
        }
    }
}
