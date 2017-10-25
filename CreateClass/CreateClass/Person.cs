using System;

namespace CreateClass
{

    public class Person
    {
        public enum Genders { Male, Female };

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }

        public Person() { }

        public Person(string Name, DateTime BirthDate, Genders Gender)
        {
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return "\n Name: " + Name +
                   "\n Date of Birth: " + BirthDate +
                   "\n Gender: " + Gender;
        }
    }
}
