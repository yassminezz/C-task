using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab1
{

    public class student
    {
        public static int lastId = 0;
        public int id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<subject> subjects { get; set; }
        public student()
        {
            
        }
        public student(string FirstName , string LastName ,List<subject>subjects) {
            this.id = generateId();
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.subjects = subjects?? new List<subject>();
        }


        public static int generateId()
        {
            return lastId++;
        }
    }
}
