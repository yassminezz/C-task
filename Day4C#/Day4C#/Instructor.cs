using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Instructor:Person
    {
        public List<Cources> CoursesTaught { get; } 

        public Instructor(string name, int age) : base(name, age) {
            CoursesTaught = new List<Cources>();
        }

        public void TeachCourse(Cources course)
        {
            course.Instructor = this;
            CoursesTaught.Add(course);
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, an Teacher.");
        }
    }
}
