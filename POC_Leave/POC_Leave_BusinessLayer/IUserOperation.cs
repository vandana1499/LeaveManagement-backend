using POC_Leave_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Leave_BusinessLayer
{
    public interface IUserOperation
    {
        User GetDetailsByEmpID(string EmpId);
        string Login();
    }
}
