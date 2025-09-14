using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Calc
    {
        public int Sum(int a, int b) => a + b;
        public double Sum(double a, double b) => a + b;

        public int Sub(int a, int b) => a - b;
        public double Sub(double a, double b) => a - b;

        public int Mul(int a, int b) => a * b;
        public double Mul(double a, double b) => a * b;

        public int Div(int a, int b) => a / b;
        public double Div(double a, double b) => a / b;
    }
}
