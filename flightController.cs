using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using flightmvc.Models;


namespace flightmvc.Controllers
{
    public class flightController : Controller
    {
        // GET: flight
          public static List<flightmodel> f = new List<flightmodel>();
      public static  List<crewmodel> c = new List<crewmodel>();
        static flightController()
        {
            crewmodel c = new crewmodel { crewid = 1, crewname = "vikram", crewdesig = "flightattendant" };
            crewmodel c1 = new crewmodel { crewid = 2, crewname = "vikas", crewdesig = "flightattendant" };
            crewmodel c2 = new crewmodel { crewid = 5, crewname = "vidya", crewdesig = "flightattendant" };
            crewmodel c3 = new crewmodel { crewid = 9, crewname = "sreeraksha", crewdesig = "flightattendant" };
            crewmodel d = new crewmodel { crewid = 6, crewname = "ankush", crewdesig = "captain" };
            crewmodel d1 = new crewmodel { crewid = 7, crewname = "anish", crewdesig = "captain" };
            crewmodel d2 = new crewmodel { crewid = 8, crewname = "abhay", crewdesig = "captain" };
            crewmodel d3 = new crewmodel { crewid = 6, crewname = "ankush", crewdesig = "captain" };
            crewmodel p = new crewmodel { crewid = 3, crewname = "vasu", crewdesig = "doctor" };
            crewmodel p1 = new crewmodel { crewid = 11, crewname = "vasudha", crewdesig = "doctor" };
            flightcrew m = new flightcrew();
            m.flightid = 1;
            m.cr = new List<crewmodel> { c, d, p };
            flightcrew m1 = new flightcrew();
            m1.flightid = 2;
            m1.cr = new List<crewmodel> { c1, d1, p1 };
            flightcrew m2 = new flightcrew();
            m2.flightid = 3;
            m2.cr = new List<crewmodel> { c2, d2, p };
            flightcrew m4 = new flightcrew();
            m4.flightid = 1;
            m4.cr = new List<crewmodel> { c3, d3, p1 };

            f.Add(new flightmodel { flightid = 1, flightname = "kingfisher", flightarrival =new DateTime(2020,12,02,02,55,50) , flightdeparture = new DateTime(2020,12,03,03,55,45), passengercnt = 250, captainid = 2,crewdetails=m.cr });
            f.Add(new flightmodel { flightid = 2, flightname = "indigo", flightarrival = new DateTime(2020, 11, 03,01,50,32), flightdeparture = new DateTime(2020, 12, 02,12,05,55), passengercnt = 350, captainid = 3,crewdetails=m1.cr });
            f.Add(new flightmodel { flightid = 3, flightname = "airindia", flightarrival = new DateTime(2020, 12, 03,11,45,35), flightdeparture = new DateTime(2020, 12, 02,3,43,33), passengercnt = 300, captainid = 2,crewdetails=m2.cr});
            f.Add(new flightmodel { flightid = 4, flightname = "gofirst", flightarrival = new DateTime(2020, 9, 06,5,34,55), flightdeparture = new DateTime(2020, 6, 03,4,55,45), passengercnt = 400, captainid = 1,crewdetails=m4.cr});
            f.Add(new flightmodel { flightid = 5, flightname = "airasiaindia", flightarrival = new DateTime(2020, 05, 04,6,43,34), flightdeparture = new DateTime(2020, 02, 01,4,54,55), passengercnt = 450, captainid = 3 });

           
            

            //c.Add(new crewmodel { crewid = 1, crewname = "vikram", crewdesig = "flightattendant" });
            //c.Add(new crewmodel { crewid = 2, crewname = "vikas", crewdesig = "flightattendant" });
            //c.Add(new crewmodel { crewid = 3, crewname = "vasu", crewdesig = "doctor" });
            //c.Add(new crewmodel { crewid = 11, crewname = "vasudha", crewdesig = "doctor" });
            //c.Add(new crewmodel { crewid = 4, crewname = "vinith", crewdesig = "captain" });
            //c.Add(new crewmodel { crewid = 5, crewname = "vidya", crewdesig = "flightattendant" });
            //c.Add(new crewmodel { crewid = 6, crewname = "ankush", crewdesig = "captain" });
            //c.Add(new crewmodel { crewid = 7, crewname = "anish", crewdesig = "captain" });
            //c.Add(new crewmodel { crewid = 8, crewname = "abhay", crewdesig = "captain" });
            //c.Add(new crewmodel { crewid = 9, crewname = "vijay", crewdesig = "flightattendant" });
            //c.Add(new crewmodel { crewid = 10, crewname = "sreeraksha", crewdesig = "flightattendant" });

        }

        public ActionResult Listflight()
        {
            return View(f);
        }
        public ActionResult Addflight()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Addflight(flightmodel flight)
        {
            f.Add(new flightmodel { flightid = flight.flightid,flightname=flight.flightname,flightarrival=flight.flightarrival,flightdeparture=flight.flightdeparture,captainid=flight.captainid,passengercnt=flight.passengercnt }) ;
            return View();
        }

        public ActionResult updateflight(int id)
        {
            var flighttoupdate = f.Find(f => f.flightid == id);
            return View(flighttoupdate);
        }
        [HttpPost]
        public ActionResult updateflight(int id,flightmodel f3)
        {
            var flighttoupdate = f.Find(f1 => f1.flightid == id);
            flighttoupdate.flightid = id;
            flighttoupdate.flightname = f3.flightname;
            flighttoupdate.flightarrival = f3.flightarrival;
            flighttoupdate.flightdeparture = f3.flightdeparture;
            flighttoupdate.captainid = f3.captainid;
            flighttoupdate.passengercnt = f3.passengercnt;
            return RedirectToAction("Listflight");


        }

        public ActionResult cancelflight(int id)
        {
            var f3 = f.Find(f4 => f4.flightid == id);
            
            return View(f3);
        }
        [HttpPost]
        public ActionResult cancelflight(int id,flightmodel f5)
        {
            var f3 = f.Find(f4 => f4.flightid == id);
            f.Remove(f3);
            return RedirectToAction("Listflight");
        }
        public ActionResult details(int id)
        {
            var flighttoupdate = f.Find(f => f.flightid == id);
            ViewBag.crew = flighttoupdate.crewdetails;
            return View(flighttoupdate);
            

           
        }

    }
}