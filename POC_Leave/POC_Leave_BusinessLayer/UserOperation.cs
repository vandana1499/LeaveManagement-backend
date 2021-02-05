using POC_Leave_DataAccessLayer;
using POC_Leave_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Leave_BusinessLayer
{
    public class UserOperation : IUserOperation
    {
        public IUserRepo iuserRepo;
        public UserOperation(IUserRepo userRepo)
        {
            iuserRepo = userRepo;
        }

        public User GetDetailsByEmpID(string EmpId)
        {
            return iuserRepo.GetDetailsByEmpID(EmpId);
        }

        public string Login()
        {
            return "You are logged in";
        }

       
    }
}
