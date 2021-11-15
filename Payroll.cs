using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBAL
{
   public  class Payroll
    {
        public int Empid { get; set; }
        public int BankaccountNo { get; set; }
        public int Basicpay { get; set; }
        public int HRA { get; set; }
        public int Medicalallowance { get; set; }
        public int Tax { get; set; }
        public int Bonus { get; set; }
        public int Noofworkdays { get; set; }
        public int Grosspay { get; set; }
        public int Pfno { get; set; }

    }
}
