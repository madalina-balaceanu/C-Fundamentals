
namespace MyHomework
{
    using System;

    class NegativeLeaveDays : Exception
    {
        public NegativeLeaveDays(string message):
            base(message)
        {

        }
    }
}
