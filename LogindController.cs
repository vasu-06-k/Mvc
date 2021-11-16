using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HRBAL;
using HRDAL;

namespace Login.Controllers

{
    
    public class LogindController : ApiController
    {

        //[HttpPost]

        //public IHttpActionResult LoginAdmin(login L)
        //{
        //    LoginDAL dal = new LoginDAL();
        //    int status = dal.ValidateUser(L);

        //    if (status == 0)
        //    {
        //        return Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
        //    }
        //    else
        //    {
        //        return Ok(new { status = 200, isSuccess = true, message = "User Login successfully" });
        //    }
        //}

        //[HttpPost]

        //public IHttpActionResult insert([FromBody]Employeedetails L)
        //{
        //    LoginDAL dal = new LoginDAL();
        //     dal.add(L);

           
            
        //        return Ok(new { status = 200, isSuccess = true, message = "Employee added successfully" });
            
        //}
        [HttpPost]

        public IHttpActionResult updates(int i,[FromBody] Employeedetails L)
        {
            LoginDAL dal = new LoginDAL();
            dal.update(i,L);



            return Ok(new { status = 200, isSuccess = true, message = "Employee updated successfully" });

        }


    }
}

