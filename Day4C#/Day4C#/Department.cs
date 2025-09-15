using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; }
        public List<Instructor> Instructors { get; } = new List<Instructor>();


        public Department(string name)
        {
            Employees = new List<Employee>();
            Name = name;
        }
    }
}
