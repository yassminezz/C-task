using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("TechCorp");
            var dept1 = new Department("IT");
            var dept2 = new Department("HR");

            var emp1 = new Employee("Alice");
            var emp2 = new Employee("Bob");
            dept1.Employees.Add(emp1);
            dept2.Employees.Add(emp2);

            var instructor1 = new Instructor("Dr. Smith", 40);
            var instructor2 = new Instructor("Prof. Jane", 45);
            dept1.Instructors.Add(instructor1);
            dept2.Instructors.Add(instructor2);


            company.departmentList.Add(dept1);
            company.departmentList.Add(dept2);

            var c1 = new Cources("C# Basics");
            var c2 = new Cources("Advanced Databases");

     
            instructor1.TeachCourse(c1);
            instructor2.TeachCourse(c2);

    
            var s1 = new Student("Charlie", 20);
            var s2 = new Student("Diana", 22);

            s1.RegisterCourse(c1);
            s1.RegisterCourse(c2);
            s2.RegisterCourse(c1);

            s1.Grades.Add(new Grade(80));
            s1.Grades.Add(new Grade(90));
            s2.Grades.Add(new Grade(85));

            Console.WriteLine("\n=== Report ===");

            foreach (var student in new[] { s1, s2 })
            {
                Grade total = new Grade(0);
                foreach (var g in student.Grades) total += g;

                Console.WriteLine($"{student.Name}:");
                foreach (var c in student.Courses)
                    Console.WriteLine($"  Course: {c.Title} ({c.Level})");
                Console.WriteLine($"  Total Grade: {total.Value}");
            }

            foreach (var dept in company.departmentList)
            {
                foreach (var instructor in dept.Instructors)
                {
                    Console.WriteLine($"{instructor.Name} teaches:");
                    foreach (var c in instructor.CoursesTaught)
                        Console.WriteLine($"  {c.Title}");
                }
            }

            foreach (var dept in company.departmentList)
            {
                Console.WriteLine($"Department {dept.Name}: {dept.Employees.Count} employees");
            }

        }
    }
}
