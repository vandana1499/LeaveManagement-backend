using Microsoft.AspNetCore.Mvc;
using POC_Leave_BusinessLayer;
using POC_Leave_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC_Leave_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public IUserOperation Iuser;
        public UserController(IUserOperation userOperation)
        {
            Iuser = userOperation;
        }
        [HttpPost]
        [Route("user-login")]
        public ActionResult Login([FromBody] Object obj)
        {
            return Ok(Iuser.Login());
        }

        [HttpGet]
        [Route("user-dashboard")]
        public ActionResult<User> GetAllDetailsByEmpId(string empid)
        {
            return Ok(Iuser.GetDetailsByEmpID(empid));
        }
    }
}
