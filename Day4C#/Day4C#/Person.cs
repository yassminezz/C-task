using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public static class IdGenerator
    {
        private static int _currentId = 0;
        public static int GenerateId() => ++_currentId;
    }

    public abstract class Person
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Id = IdGenerator.GenerateId();
            Name = name;
            Age = age;
        }
        public abstract void Introduce();
    }
}
