using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }

        public Room Room = new Room();

        

        public Employee() { }

        public override string ToString()
        {
            return base.ToString() + 
                   "\n Salary: " + Salary +
                   "\n Profession: " + Profession;
        }
    }
}
