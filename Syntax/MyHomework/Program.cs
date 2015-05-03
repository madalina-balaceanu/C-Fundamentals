namespace MyHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var leave1 = new Leave(new DateTime(2013, 03, 22), 5, LeaveType.Holiday);
            var leave2 = new Leave(new DateTime(2014, 09, 09), 5, LeaveType.Holiday);
            var leave3 = new Leave(new DateTime(2015, 05, 15), 40, LeaveType.Holiday);
            var leave4 = new Leave(new DateTime(2015, 09, 15), 65, LeaveType.Holiday);
            var leave5 = new Leave(new DateTime(2013, 03, 25), 10, LeaveType.Holiday);
            Employee em1 = new Employee("Madalina", "Balaceanu", new DateTime(1993, 09, 22), new DateTime(2012, 09, 09), 1500, 60);

            em1.DisplayInfo();
            Console.ReadKey();

            em1.AddNewLeave(leave1);
            em1.AddNewLeave(leave2);
            em1.AddNewLeave(leave3);
            em1.ShowLeaves(2015);

            //se arunca o exceptie daca perioada in care se incearca sa se introduca un
            //concediu nu este disponibil
         /*
           em1.AddNewLeave(leave5);
            Console.ReadKey();
        */
            em1.AddNewLeave(leave4);
            Console.ReadKey();
        }
    }
}
