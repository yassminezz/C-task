using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDay3.Models
{
    public class Project
    {
        [Key]
        public int Pnumber { get; set; }
        public string Pname { get; set; }
        public string Plocation { get; set; }
        public string City { get; set; }

        public int DeptID { get; set; }   // FK

        // ✅ Tell EF that this uses DeptID as the FK
        [ForeignKey("DeptID")]
      
        public Department Department { get; set; }
    }

}
