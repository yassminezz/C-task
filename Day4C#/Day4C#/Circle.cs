using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Circle : Shape, IDraw
    {

        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Radius * Radius;

        public void Draw()
        {
            Console.WriteLine("Drawing a Circle O");
        }
    }
}
