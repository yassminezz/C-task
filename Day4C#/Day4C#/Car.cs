using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4C_
{
    public class Car
    {
        private Engine Engine { get; set; }  // Composition
        public Car(string engineType)
        {
            Engine = new Engine(engineType);
        }
    }
}
