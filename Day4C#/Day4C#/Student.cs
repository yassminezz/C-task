using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day4C_
{
    public class Student:Person
    {
        public List<Cources> Courses { get; }
        public List<Grade> Grades { get; }

        public Student(string name, int age) : base(name, age) {
            Grades = new List<Grade>();
        Courses = new List<Cources>();
        }

        public void RegisterCourse(Cources course)
        {
            Courses.Add(course);
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, a Learner.");
        }
    }
}
