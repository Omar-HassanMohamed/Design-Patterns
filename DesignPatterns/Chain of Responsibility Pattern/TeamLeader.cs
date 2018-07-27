using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Chain_of_Responsibility_Pattern
{
    public class TeamLeader : Employee
    {
        // team leas can only approve upto 9 days of leave
        const int MAX_LEAVES_CAN_APPROVE = 10;

        // in constructor we will attach the event handler that
        // will check if this employee can process or he need to
        // pass on to next employee
        public TeamLeader()
        {
            this.onLeaveApplied += new OnLeaveApplied(TeamLeader_onLeaveApplied);
        }

        // in this function we will check if this employee can 
        // process or he need to pass on to next employee
        void TeamLeader_onLeaveApplied(Employee employee,Leave leave)
        {
            // check if we can process this request
            if (leave.NumberOfDays < MAX_LEAVES_CAN_APPROVE)
            {
                // process it on our level only
                ApproveLeave(leave);
            }
            else
            {
                // if we cant process pass on to the supervisor 
                // so that he can process
                if (Supervisor != null)
                    supervisor.LeaveApplied(this, leave);
            }
        }

        // If we can process lets show the output
        public override void ApproveLeave(Leave leave)
        {
            Console.WriteLine("LeaveID: {0} Days: {1} Approver: {2}",leave.LeaveId, leave.NumberOfDays, "Team Leader");
        }
    }
}
