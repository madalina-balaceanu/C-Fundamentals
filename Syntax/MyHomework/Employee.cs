using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {

        public string dateOfEmployment;
        public int salary;
        public int availableDaysOff;
        List<Leave> leaves = new List<Leave>();

        public Employee(string Lastname, string Firstname, string DateOfBirth,
        string DateOfEmployment, int Salary, int AvailableDaysOff)
            : base(Lastname, Firstname, DateOfBirth)
        {

            this.availableDaysOff = AvailableDaysOff;
            this.salary = Salary;
            this.dateOfEmployment = DateOfEmployment;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(" Detali angajat");
            Console.WriteLine(" Nume :" + this.firstname + "\n Prenume :" +
                this.lastname + "\n Salariu :" + this.salary + "\n Numar zile disonibile :" + this.availableDaysOff + "\n");
        }

        public int SubstractDays(int subDay)
        {
            return this.availableDaysOff -= subDay;
        }


        public void AddNewLeave(Leave leave)
        {
            if (this.availableDaysOff <= leave.duration)
                throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");

            SubstractDays(leave.duration);
            this.leaves.Add(leave);
            leave.employee = this;
        }

        public void ShowLeaves()
        {
            foreach (var i in this.leaves)
            {
                if (i.startingDate.Contains("2015"))
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
