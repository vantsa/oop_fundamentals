using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_fundamentals
{
    internal class Person
    {
        public enum Genders
        {
            Female,
            Male,
            Other,
        };

        #region Auto Properties
        public String Name { get; set; }
        public Genders Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        #endregion

        #region Constructors
        public Person(string Name, Genders Gender,  DateTime DateOfBirth)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
        }

        public Person(Person p)
        {
            this.Name = p.Name;
            this.Gender = p.Gender;
            this.DateOfBirth = p.DateOfBirth;
        }
        #endregion

        #region Method

        public override string ToString() 
        {
            return String.Format($"Name: {this.Name}\n" +
                $"Gender: {this.Gender}\n" +
                $"Date of birth: {this.DateOfBirth:yyyy-MM-dd}\n");                   
        }
        #endregion
    }
}
