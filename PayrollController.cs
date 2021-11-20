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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PayrollController : ApiController
    {
        [HttpGet] //display particular employee

        public Payroll displayupdate(int id)
        {
           payrollDAL  dal = new payrollDAL();
            Payroll e1 = dal.displaypayroll(id);
            return e1;




        }
        [HttpPut]
        
        public IHttpActionResult updates([FromBody] Payroll L)
        {
          payrollDAL  dal = new payrollDAL();
            dal.updatedetails(L);



            return Ok(new { status = 200, isSuccess = true, message = "Details Added successfully" });

        }

    }
}
