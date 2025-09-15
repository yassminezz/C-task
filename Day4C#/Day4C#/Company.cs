using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day4C_
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> departmentList;
        public Company(string name)
        {
            Name = name;
            departmentList =new List<Department>();
        }
    }
}
