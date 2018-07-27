using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Chain_of_Responsibility_Pattern
{
    public class Leave
    {
        Guid _leaveId;
        int _numberOfDays;
        public Guid LeaveId
        {
            get { return _leaveId; }
            set { _leaveId = value; }
        }

       
        public int NumberOfDays
        {
            get { return _numberOfDays; }
            set { _numberOfDays = value; }
        }
        
        public Leave(Guid guid , int days)
        {
            _leaveId = guid;
            _numberOfDays = days;
        }
    }
}
