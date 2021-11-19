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
    public class PerfomanceController : ApiController
    {
        [HttpGet]
        public List<perfomance> showallperfomance()
        {
            PerfomanceDAL d = new PerfomanceDAL();
            List<perfomance> f = d.displayperfomance();
            return f;


        }
        [HttpPost]
        public IHttpActionResult Postperfomance([FromBody] perfomance L)
        {
            PerfomanceDAL d = new PerfomanceDAL();
            d.addperfomance(L);



            return Ok(new { status = 200, isSuccess = true, message = "Perfomance of employee added successfully" });

        }
    }
}
