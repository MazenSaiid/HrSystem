using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.OOP.Syste_
{
    internal abstract class Person
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }


        public void SetName(string firstName,string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid Name");
            FirstName = firstName;
            LastName = lastName;
        }
        public void SetBirthDate(DateOnly birthdate)
        {
            if (birthdate < new DateOnly(1920,1,1))
                throw new ArgumentException("Invalid Birthdate");
            BirthDate = birthdate;
        }
    }
}
