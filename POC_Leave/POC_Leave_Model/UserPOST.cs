using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POC_Leave_Model
{
    public class UserPOST
    {
        [Required]
        public string EmpID { get; set; }
        [Required]
        public string password { get; set; }
    }
}
