using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class NegativeLeaveDays : Exception
    {
        public NegativeLeaveDays(string message):
            base(message)
        {

        }
    }
}
