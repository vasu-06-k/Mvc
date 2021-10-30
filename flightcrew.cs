using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace flightmvc.Models
{
    public class flightcrew
    {
        public int flightid { get; set; }
        public List<crewmodel>cr { get; set; }
    }
}