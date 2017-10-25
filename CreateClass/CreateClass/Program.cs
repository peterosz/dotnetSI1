using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee
            {
                Name = "Sanya",
                BirthDate = 1988,
                Gender = Person.Genders.Male,
                Salary = 500,
                Profession = "Kommunális Operátor"
            };

            Employee person2 = new Employee
            {
                Name = "Mariska",
                BirthDate = 1999,
                Gender = Person.Genders.Female,
                Salary = 1500,
                Profession = "Key Account Manager"
            };

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
