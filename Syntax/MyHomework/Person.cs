﻿
namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Person
    {

        protected string lastName;
        protected string firstName;
        protected DateTime dateOfBirth;

        public Person(string lastName, string firstName, DateTime dateOfBirth)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
