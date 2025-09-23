using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {

      
        static void Main(string[] args)
        {
            Product p = new Product("Milk", 40);

            var prod = p.createProduct();

            Console.WriteLine($"product name : {prod.namee}, price is : {prod.pricee}");
        }
    }
}
