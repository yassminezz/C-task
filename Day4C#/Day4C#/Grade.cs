using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Grade
    {
        public int Value { get; set; }
        public Grade(int value)
        {
            Value = value;
        }

        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade(g1.Value + g2.Value);
        }

        public static bool operator ==(Grade g1, Grade g2)
        {
            return g1.Value == g2.Value;
        }

        public static bool operator !=(Grade g1, Grade g2)
        {
            return g1.Value != g2.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Grade g) return Value == g.Value;
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
