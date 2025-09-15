using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Rectangle : Shape, IDraw
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;

        public  void Draw()
        {
            Console.WriteLine("Drawing a Rectangle []");
        }
    }
}
