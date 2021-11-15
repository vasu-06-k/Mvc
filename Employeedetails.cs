using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HRBAL
{
    public class Employeedetails
    {
        public int   empid{ get; set; }
        string _emname;
        public string EmployeeName
        {
            get { return _emname; }
            set
            {
                if (value.Length > 0)
                {
                    _emname = value;
                }
                else
                {
                    throw new ArgumentNullException("Employee Name can't be blank or null");
                }
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        string _gender;
        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value.Length > 0)
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentNullException("Gender can't be blank or null");
                }
            }
        }

        string _empst;
        public string EmpStatus
        {
            get { return _empst; }
            set
            {
                if (value.Length > 0)
                {
                    _empst = value;
                }
                else
                {
                    throw new ArgumentNullException("Employee status can't be blank or null");
                }
            }
        }

        string _desg;
        public string Designation
        {
            get { return _desg; }
            set
            {
                if (value.Length > 0)
                {
                    _desg = value;
                }
                else
                {
                    throw new ArgumentNullException("Designation can't be blank or null");
                }
            }
        }

        int _deptno;
        public int DeptNo
        {
            get { return _deptno; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Dept No cannot be null or zero");
                }
                else
                {
                    _deptno = value;
                }
            }
        }

        string _addr;
        public string Address
        {
            get { return _addr; }
            set
            {
                if (value.Length > 0)
                {
                    _addr = value;
                }
                else
                {
                    throw new ArgumentNullException("Address can't be blank or null");
                }
            }
        }
        string _nation;
        public string Nationality
        {
            get { return _nation; }
            set
            {
                if (value.Length > 0)
                {
                    _nation = value;
                }
                else
                {
                    throw new ArgumentNullException("Nationality can't be blank or null");
                }
            }
        }

        int _phone;
        public int PhoneNo
        {
            get { return _phone; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Phone No cannot be null or zero");
                }
                else
                {
                    _phone = value;
                }
            }
        }
        int _mngid;
        public int ManagerId
        {
            get { return _mngid; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Manager id cannot be null or zero");
                }
                else
                {
                    _mngid = value;
                }
            }
        }
        string _loc;
        public string WorkLoc
        {
            get { return _loc; }
            set
            {
                if (value.Length > 0)
                {
                    _loc = value;
                }
                else
                {
                    throw new ArgumentNullException("Work Location can't be blank or null");
                }
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Joiningdate { get; set; }

    }
}
}
