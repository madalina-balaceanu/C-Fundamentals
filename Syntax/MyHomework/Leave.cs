using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {

        public string startingDate;
        public int duration;
        public Employee employee;
        public string leaveType;

        public Leave(string startingDate, int duration, string leaveType)
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
