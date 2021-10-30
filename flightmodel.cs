using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace flightmvc.Models
{
    public class flightmodel
    {
        public int flightid { get; set; }
        public string flightname { get; set; }
        public DateTime flightarrival { get; set; }
        public DateTime flightdeparture { get; set; }
        public int passengercnt { get; set; }
        public int captainid { get; set; }
        public List<crewmodel> crewdetails { get; set; }
    }
}