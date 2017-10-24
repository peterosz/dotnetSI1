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
            Person person1 = new Person();

            person1.Name = "Sanya";
            person1.BirthDate = 1988;
            person1.Gender = Person.Genders.Male;

            Person person2 = new Person();
            person2.Name = "Mariska";
            person2.BirthDate = 1999;
            person2.Gender = Person.Genders.Female;


            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
