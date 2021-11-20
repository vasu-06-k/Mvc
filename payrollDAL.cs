using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRBAL;

namespace HRDAL
{
    public class payrollDAL
    {
        public Payroll displaypayroll(int id)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from PayRoll", cn);
            d.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet t = new DataSet();
            d.Fill(t);
            
            DataRow r=t.Tables[0].Rows.Find(id);


            Payroll e2 = new Payroll();
            //e2.Empid = Convert.ToInt32(r["EmpId"]);
            e2.BankaccountNo = Convert.ToInt32(r["BankAccountNo"]);
            //e2.Pfno = Convert.ToInt32(r["ProvidentFundNo"]);
            e2.Basicpay = Convert.ToInt32(r["BasicPay"]);
            e2.HRA = Convert.ToInt32(r["HRA"]);
            e2.Medicalallowance = Convert.ToInt32(r["MedicalAllowance"]);
            e2.Tax = Convert.ToInt32(r["Tax"]);
            e2.Bonus = Convert.ToInt32(r["Bonus"]);
            e2.Grosspay = Convert.ToInt32(r["GrossPay"]);
            e2.Noofworkdays = Convert.ToInt32(r["NoOfWorkDays"]);
            return e2;

        }
        public void updatedetails(Payroll e)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-IU1NK3H4\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");

            SqlDataAdapter d = new SqlDataAdapter("select * from PayRoll", cn);
            d.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet t = new DataSet();
            d.Fill(t);
            //d.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataRow r = t.Tables[0].Rows.Find(e.Empid);
            r[1] = e.BankaccountNo;
            r[2] = e.Pfno;
            

            SqlCommandBuilder b = new SqlCommandBuilder(d);
            d.Update(t);



        }
    }
}