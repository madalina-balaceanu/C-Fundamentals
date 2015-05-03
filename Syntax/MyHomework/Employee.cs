namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Employee : Person
    {

        public DateTime dateOfEmployment;
        public double salary;
        public int availableDaysOff;
        Dictionary<int, int> availableDaysOffTotal = new Dictionary<int, int>();
        List<Leave> leaves = new List<Leave>();

        public Employee(string lastName, string firstName, DateTime dateOfBirth,
        DateTime dateOfEmployment, double Salary, int availableDaysOff)
            : base(lastName, firstName, dateOfBirth)
        {

            this.availableDaysOff = availableDaysOff;
            this.salary = Salary;
            this.dateOfEmployment = dateOfEmployment;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(" Detali angajat");
            Console.WriteLine(" Nume :" + this.firstName + "\n Prenume :" +
                this.lastName + "\n Salariu :" + this.salary + "\n Numar zile disponibile :" + this.availableDaysOff + "\n");
        }

        private int SubstractDays(int subDay, int availableDaysOffOneYear)
        {
            return availableDaysOffOneYear -= subDay;
        }


        public void AddNewLeave(Leave leave)
        {
            if (IsAnotherLeaveApproved(leave) == true)
            {
                if (availableDaysOffTotal.ContainsKey(leave.startingDate.Year) == false)
                {
                    availableDaysOffTotal.Add(leave.startingDate.Year, availableDaysOff);
                }

                if (availableDaysOffTotal[leave.startingDate.Year] < leave.duration)
                {
                    throw new NegativeLeaveDays("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
                }else {
                    SubstractDays(leave.duration, availableDaysOffTotal[leave.startingDate.Year]);
                    this.leaves.Add(leave);
                    leave.employee = this;
                }

            }
            else
            {
                throw new AlreadyOcupateLeave(" Perioada deja alocata pentru concediu");
            }
        }


        public void ShowLeaves(int year)
        {
            foreach (var leave in this.leaves)
                if (leave.startingDate.Year.Equals(year))
                    Console.WriteLine(leave.ToString());
        }

        private bool IsAnotherLeaveApproved(Leave currenLeave)
        {
            // verifica daca mai exista cel putin un alt concediu aprobat in perioada in care
            // se doreste aprobarea concediului curent
            DateTime pastLeaveEnd;
            DateTime currenLeaveDate= currenLeave.startingDate;
            int compareStartEndTime,compareEndStartTime;
            DateTime currenLeaveEnd = currenLeaveDate.AddDays(currenLeave.duration);

            foreach (var leave in this.leaves)
            {
                pastLeaveEnd = leave.startingDate.AddDays(leave.duration);

                compareStartEndTime =  DateTime.Compare(currenLeaveDate,pastLeaveEnd);
                compareEndStartTime =  DateTime.Compare(currenLeaveEnd,leave.startingDate);

                if (compareEndStartTime != compareStartEndTime) 
                {
                    return false;
                }
             }
          
            return true;
        }      

    }
}
