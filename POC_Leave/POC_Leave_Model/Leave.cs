using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Leave_Model
{
    public enum LeaveType
    {
        Leave=0,
        ComapanyHoliday=1,
        Weekend=2,
        Half_Day_Leave=3,
        Tentative_Leave=4,
        Weekend_Work=5

    }
    public class Leave
    {
        public string Date { get; set; }
        public string Day { get; set; }
        public LeaveType LeaveType { get; set; }
    }
}
