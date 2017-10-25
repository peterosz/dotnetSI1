using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }

        public Room Room = new Room();
              

        public Employee() { }
        
        public Employee(string Name, DateTime BirthDate, Genders Gender, int Salary, string Profession)
        {
            base.Name = Name;
            base.BirthDate = BirthDate;
            base.Gender = Gender;
            this.Salary = Salary;
            this.Profession = Profession;
        }
       
        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.RoomNumber);
            return newEmployee;
        }

        public override string ToString()
        {
            return base.ToString() + 
                   "\n Salary: " + Salary +
                   "\n Profession: " + Profession;
        }
    }
}
