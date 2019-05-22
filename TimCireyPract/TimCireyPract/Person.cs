using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimCireyPract
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
