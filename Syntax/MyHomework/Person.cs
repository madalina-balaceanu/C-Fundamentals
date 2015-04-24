using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Person
    {

        protected string lastname;
        protected string firstname;
        protected string dateOfBirth;

        public Person(string Lastname, string Firstname, string DateOfBirth)
        {
            this.lastname = Lastname;
            this.firstname = Firstname;
            this.dateOfBirth = DateOfBirth;
        }
    }
}
