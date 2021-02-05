using POC_Leave_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Leave_DataAccessLayer
{
    public interface IUserRepo
    {
        User GetDetailsByEmpID(string empid);


    }
}
