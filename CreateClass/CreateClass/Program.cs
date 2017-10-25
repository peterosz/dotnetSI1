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
                BirthDate = new DateTime(1988, 07, 10),
                Gender = Person.Genders.Male,
                Salary = 500,
                Profession = "Kommunális Operátor"
            };

            Employee person2 = new Employee
            {
                Name = "Mariska",
                BirthDate = new DateTime(1999, 02, 01),
                Gender = Person.Genders.Female,
                Salary = 1500,
                Profession = "Key Account Manager"
            };

            Employee Kovacs = new Employee("Géza", DateTime.Now, Person.Genders.Male, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
