using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee("Balaceanu", "Madalina", "22.09.1993", "09.05.2010", 1500, 60);
            Leave leave1 = new Leave("11.10.2010", 23, "holiday");
            Leave leave2 = new Leave("15.08.2015", 25, "holiday");
            Leave leave3 = new Leave("11.10.2010", 65, "holiday");


            em1.DisplayInfo();
            Console.ReadKey();

            em1.SubstractDays(4);
            em1.DisplayInfo();
            Console.ReadKey();

            em1.AddNewLeave(leave1);
            em1.AddNewLeave(leave2);
            em1.ShowLeaves();
            Console.ReadKey();

            em1.AddNewLeave(leave3);
            em1.DisplayInfo();
            Console.ReadKey();
        }
    }
}
