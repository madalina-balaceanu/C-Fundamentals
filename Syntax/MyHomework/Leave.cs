namespace MyHomework
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Leave
    {
        public DateTime startingDate;
        public int duration;
        public Employee employee;
        public LeaveType leaveType;

        public Leave(DateTime startingDate, int duration, LeaveType leaveType)
        {
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leaveType;
        }

        public override string ToString()
        {
            return "\n startingDate : " + this.startingDate + "\n duration : " +
                this.duration + "\n leaveType: " + this.leaveType;
        }

    }
}
