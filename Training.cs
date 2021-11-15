using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBAL
{
  public  class Training
    {
        public int Empid { get; set; }
        public int Batchno { get; set; }
        public string Batchname { get; set; }
        public int TraineerId { get; set; }
        public int MangerId { get; set; }
        public DateTime startdate{ get; set; }
        public DateTime enddate { get; set; }
        public string Status { get; set; }
    }
}
