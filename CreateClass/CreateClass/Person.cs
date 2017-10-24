using System;

namespace CreateClass
{

    public class Person
    {
        public enum Genders { Male, Female };

        public string Name { get; set; }
        public int BirthDate { get; set; }
        public Genders Gender { get; set; }

        public Person() { }

        public override string ToString()
        {
            return "\n Name: " + Name +
                   "\n Date of Birth: " + BirthDate +
                   "\n Gender: " + Gender;
        }
    }
}
