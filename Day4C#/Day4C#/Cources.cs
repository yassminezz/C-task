using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CourseLevel { Beginner, Intermediate, Advanced }
namespace Day4C_
{
    public class Cources
    {
        public string Title { get; set; }
        public CourseLevel Level { get; set; }
        public Instructor Instructor { get; set; }
        public Cources(string title)
        {
            Title = title;
        }
        public void AssignInstructor(Instructor instructor)
        {
            Instructor = instructor;
        }
    }
}
