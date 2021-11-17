using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HRBAL;
using HRDAL;

namespace Login.Controllers
    //[EnableCors(origins:"*",headers:"*",methods:"*")]

{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    [RoutePrefix("api/VTRouting")]
    public class LogindController : ApiController
    {

        [HttpPost]
        [Route("Admin")]
        public IHttpActionResult LoginAdmin(login L)
        {
            LoginDAL dal = new LoginDAL();
            int status = dal.ValidateUser(L);

            if (status == 0)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
            }
            else
            {
                return Ok(new { status = 200, isSuccess = true, message = "User Login successfully" });
            }
        }

        [HttpPost]
        [Route("insert")]
        public IHttpActionResult insert([FromBody] Employeedetails L)
        {
            LoginDAL dal = new LoginDAL();
            dal.add(L);



            return Ok(new { status = 200, isSuccess = true, message = "Employee added successfully" });

        }
        [HttpPost]
        [Route("update")]

        public IHttpActionResult updates(int i, [FromBody] Employeedetails L)
        {
            LoginDAL dal = new LoginDAL();
            dal.update(i, L);



            return Ok(new { status = 200, isSuccess = true, message = "Employee updated successfully" });

        }

        [HttpGet]
        public List<Employeedetails> showall()
        {
            LoginDAL d = new LoginDAL();
             List<Employeedetails> f=d.showall();
            return f;


        }

    }
}

