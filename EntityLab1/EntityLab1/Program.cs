using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            var sorted = (from num in numbers
                          orderby num
                          select num).Distinct();
            foreach (int num in sorted)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            foreach (int num in sorted)
            {
                Console.WriteLine($"Number ={num} , Multiply ={num * num}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            //2
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            var len3 = names.Where(n => n.Length == 3);
            foreach (var num in len3)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            var leta = names.Where(n => n.Contains('a') || n.Contains('A')).OrderBy(n => n.Length);
            foreach (var num in leta)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            var top2 = names.Skip(0).Take(2);
            foreach (var t in top2)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            List<student> students = new List<student>()
        {
            new student()
            {
                id = student.generateId(),
                FirstName = "Ali",
                LastName = "Mohammed",
                subjects = new List<subject>()
                {
                    new subject(){ code = 22, name = "EF" },
                    new subject(){ code = 33, name = "UML" }
                }
            },
            new student()
            {
                id = student.generateId(),
                FirstName = "Mona",
                LastName = "Gala",
                subjects = new List<subject>()
                {
                    new subject(){ code = 22, name = "EF" },
                    new subject(){ code = 34, name = "XML" },
                    new subject(){ code = 25, name = "JS" }
                }
            },
            new student()
            {
                id = student.generateId(),
                FirstName = "Yara",
                LastName = "Yousf",
                subjects = new List<subject>()
                {
                    new subject(){ code = 22, name = "EF" },
                    new subject(){ code = 25, name = "JS" }
                }
            },
            new student()
            {
                id = student.generateId(),
                FirstName = "Ali",
                LastName = "Ali",
                subjects = new List<subject>()
                {
                    new subject(){ code = 33, name = "UML" }
                }
            }
            };


            var studInfo = students.Select(s => new { fullName = s.FirstName + " " + s.LastName, count = s.subjects.Count() });
       
        foreach(var student in studInfo)
            {
                Console.WriteLine($"FullName ={student.fullName} ,NoOfSubjects ={student.count}");

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            var q2 = students
                .OrderByDescending(s => s.FirstName)   // first sort (descending)
                .ThenBy(s => s.LastName)               // secondary sort (ascending)
                .Select(s => new { FullName = s.FirstName + " " + s.LastName });
            foreach(var q in q2)
            {
                Console.WriteLine(q.FullName);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            var q3 = students.Select(s => new { studname = s.FirstName + " " + s.LastName, sub = s.subjects });

            foreach (var q in q3)
            {
                foreach (var s in q.sub)
                {
                    Console.WriteLine($"StudentName = {q.studname} , subjectName = {s.name}");
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            var q4= students.Select(s => new { studname = s.FirstName + " " + s.LastName, sub = s.subjects }).GroupBy(s=>s.studname);
            foreach (var group in q4)
            {
                Console.WriteLine($"Student: {group.Key}");
                foreach (var item in group)
                {
                    foreach (var subj in item.sub)
                    {
                        Console.WriteLine($"   Subject: {subj.name}");
                    }
                }
            }
        }

    }
}
