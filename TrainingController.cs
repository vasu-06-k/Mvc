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
    public class TrainingController : ApiController
    {
        [HttpGet]
        public List<Training> showall()
        {
           TrainingDAL d = new TrainingDAL();
            List<Training> f = d.showall();
            return f;


        }
        [HttpPost]
        public IHttpActionResult addtraining([FromBody] Training L)
        {
            TrainingDAL d = new TrainingDAL();
            d.addtraining(L);



            return Ok(new { status = 200, isSuccess = true, message = "Trainee added successfully" });

        }
    }
}
