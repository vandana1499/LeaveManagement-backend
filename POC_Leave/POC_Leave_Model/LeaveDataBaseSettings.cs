using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Leave_Model
{
    public class LeaveDataBaseSettings : ILeaveDataBaseSettings
    {
        public string LeaveCollectionName { get; set ; }
        public string ConnectionString { get ; set ; }
        public string DatabaseName { get ; set; }
    }
    public interface ILeaveDataBaseSettings
    {
        string LeaveCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    
}
